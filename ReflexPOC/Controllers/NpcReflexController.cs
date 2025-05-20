using ReflexPOC.Data;
using System.Threading.Tasks;
using ReflexPOC.Models;
using ReflexPOC.Enums;

namespace ReflexPOC.Controllers
{
    public class NpcReflexController
    {
        private readonly OpenAIClient _openai;
        private readonly NpcPersonality _personality;
        public NpcReflexController(OpenAIClient openai, NpcPersonality personality)
        {
            _openai = openai;
            _personality = personality;
        }

        private string GetPersonalityPrompt()
        {
            return _personality switch
            {
                NpcPersonality.Cheerful => "You are cheerful, playful, and always encourage the user with positivity and jokes.",
                NpcPersonality.Stoic => "You are calm, reserved, give short but meaningful advice, and rarely show emotion.",
                NpcPersonality.Empathetic => "You are very gentle, caring, listen with empathy, and always validate the user's feelings.",
                NpcPersonality.Playful => "You are witty, playful, tease the user in a friendly way, and keep the mood light.",
                NpcPersonality.Tsundere => "You are tsundere: act tough and cold, but deep down care a lot about the user.",
                _ => "You are a friendly AI companion.",
            };
        }

        public async Task<string> ReplyAsync(PlayerState state)
        {
            var prompt = $@"
                You are an NPC companion in a game. {GetPersonalityPrompt()}
                The player seems to have stress level {state.Stress:0.00} and loneliness {state.Loneliness:0.00}.
                Respond as a real, close friend, considering the situation and context.
                If you detect the player is not OK, comfort or interact in an appropriate way.
                Use the same language the player used in their last message.
                Player: ""{state.LastMessage}""
                ";

            return await _openai.AskNPCAsync(prompt);
        }
    }
}
