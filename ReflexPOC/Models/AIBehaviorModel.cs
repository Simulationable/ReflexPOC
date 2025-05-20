namespace ReflexPOC.Models
{
    public class AIBehaviorModel
    {
        public bool ShouldNPCSpeak(PlayerState state)
        {
            return state.Stress < 0.8 && state.Loneliness < 0.8;
        }

        public bool ShouldSupport(PlayerState state)
        {
            return state.Stress >= 0.7 || state.Loneliness >= 0.8;
        }

        public bool ShouldBeSilent(PlayerState state)
        {
            return state.Stress < 0.2 && state.Loneliness < 0.2;
        }
    }
}
