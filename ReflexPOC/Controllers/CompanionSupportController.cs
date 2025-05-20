using ReflexPOC.Models;

namespace ReflexPOC.Controllers
{
    public class CompanionSupportController
    {
        public bool NeedsSupport(PlayerState state)
        {
            return state.Stress > 0.75 || state.Loneliness > 0.8;
        }
    }
}
