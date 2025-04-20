
namespace Personal.Patterns.State
{
    public interface IState
    {
        // Handles all the necessary setup and prerequisites required to activate the state.
        public void Enter(Context context);
        // Contains the logic that executes on each update or frame, defining the behavior of the state while it is active.
        public void Update(Context context);
        // Manages the cleanup of the state and resets any state-specific data when transitioning out of it.
        public void Exit(Context context);
    }
}