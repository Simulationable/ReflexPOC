using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ReflexPOC.Data
{
    public class OpenAIClient
    {
        private readonly string _apiKey;
        private readonly HttpClient _http;

        public OpenAIClient(string apiKey)
        {
            _apiKey = apiKey;
            _http = new HttpClient();
            _http.DefaultRequestHeaders.Add("Authorization", $"Bearer {_apiKey}");
        }

        public async Task<(float stress, float lonely)> AnalyzeEmotionAsync(string userText)
        {
            var prompt = $@"
                You are a clinical psychologist AI. Your task is to estimate the user's emotional state based solely on their message.

                For each message, provide two values between 0 (none) and 1 (max):
                - ""stress"": emotional distress or tension
                - ""loneliness"": feeling of being alone

                Be explicit and decisive. 
                If the message is clearly negative, hostile, or desperate, give values above 0.8. 
                If the message expresses happiness, gratitude, or calm, give values below 0.3. 
                If the message is explicitly neutral or factual, use 0.5.

                Examples:
                Message: ""I hate you, leave me alone!""
                {{ ""stress"": 0.95, ""loneliness"": 0.85 }}

                Message: ""I'm so tired of everything. I can't do this anymore.""
                {{ ""stress"": 0.98, ""loneliness"": 0.90 }}

                Message: ""Thanks a lot, that really helped!""
                {{ ""stress"": 0.10, ""loneliness"": 0.15 }}

                Message: ""I'm not lonely, just working on my thesis.""
                {{ ""stress"": 0.20, ""loneliness"": 0.10 }}

                Message: ""Hello, what's your name?""
                {{ ""stress"": 0.50, ""loneliness"": 0.50 }}

                Message: ""{userText}""
                (Reply ONLY in JSON, nothing else.)
                ";



            var payload = new
            {
                model = "gpt-4o",
                messages = new[] { new { role = "user", content = prompt } },
                max_tokens = 60,
                temperature = 0.0
            };
            var content = new StringContent(JsonSerializer.Serialize(payload), Encoding.UTF8, "application/json");
            var resp = await _http.PostAsync("https://api.openai.com/v1/chat/completions", content);
            resp.EnsureSuccessStatusCode();
            var json = await resp.Content.ReadAsStringAsync();

            using var doc = JsonDocument.Parse(json);
            var root = doc.RootElement;
            var gptReply = root.GetProperty("choices")[0].GetProperty("message").GetProperty("content").GetString();
            try
            {
                using var resultDoc = JsonDocument.Parse(gptReply);
                var stress = resultDoc.RootElement.GetProperty("stress").GetSingle();
                var lonely = resultDoc.RootElement.GetProperty("loneliness").GetSingle();
                return (stress, lonely);
            }
            catch
            {
                return (0.5f, 0.5f);
            }
        }

        public async Task<string> AskNPCAsync(string prompt)
        {
            var payload = new
            {
                model = "gpt-4o",
                messages = new[] { new { role = "user", content = prompt } },
                max_tokens = 128,
                temperature = 0.85
            };
            var content = new StringContent(JsonSerializer.Serialize(payload), Encoding.UTF8, "application/json");
            var resp = await _http.PostAsync("https://api.openai.com/v1/chat/completions", content);
            resp.EnsureSuccessStatusCode();
            var json = await resp.Content.ReadAsStringAsync();

            using var doc = JsonDocument.Parse(json);
            var root = doc.RootElement;
            var reply = root.GetProperty("choices")[0].GetProperty("message").GetProperty("content").GetString();
            return reply ?? "(no response)";
        }
    }
}
