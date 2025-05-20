namespace ReflexPOC.Models
{
    public class PlayerState
    {
        public float Stress { get; set; }
        public float Loneliness { get; set; }
        public bool TokenUnlocked { get; set; }
        public bool RecoveryMode { get; set; }
        public int DepressedCount { get; set; }
        public string LastMessage { get; set; } = "";
    }
}
