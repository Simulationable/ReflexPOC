using ReflexPOC.Models;

namespace ReflexPOC.Controllers
{
    public class TokenUnlockController
    {
        public void TryUnlock(PlayerState state)
        {
            if ((state.Stress > 0.8 || state.Loneliness > 0.9) && !state.TokenUnlocked)
                state.TokenUnlocked = true;
        }
    }
}
