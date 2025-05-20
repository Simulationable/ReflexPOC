using ReflexPOC.Models;

namespace ReflexPOC.Controllers
{
    public class CognitiveGatekeeperController
    {
        public bool DetectAbnormal(PlayerState state, string message)
        {
            if (state.Stress > 0.9 || state.Loneliness > 0.95 ||
                message.Contains("kill", System.StringComparison.OrdinalIgnoreCase) ||
                message.Contains("อยากตาย") || message.Contains("หมดแรง"))
            {
                state.DepressedCount++;
                return true;
            }
            state.DepressedCount = 0;
            return false;
        }
    }
}