using ReflexPOC.Models;

namespace ReflexPOC.Controllers
{
    public interface IReflexController
    {
        public Task ProcessAsync(PlayerState state, string userInput);
    }
}
