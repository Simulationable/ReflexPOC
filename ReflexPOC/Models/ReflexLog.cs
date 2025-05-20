namespace ReflexPOC.Models
{
    public class ReflexLog
    {
        public int Id { get; set; }
        public DateTime Timestamp { get; set; }
        public string? ReflexType { get; set; }
        public string? Action { get; set; }
        public float Stress { get; set; }
        public float Loneliness { get; set; }
        public string? Notes { get; set; }
    }

}
