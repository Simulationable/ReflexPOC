using ReflexPOC.Models;

namespace ReflexPOC.Controllers
{
    public class RecoveryReflexController
    {
        public void TryRecovery(PlayerState state)
        {
            if ((state.Stress < 0.2 && state.Loneliness < 0.2) && !state.RecoveryMode)
                state.RecoveryMode = true;
        }
    }
}
