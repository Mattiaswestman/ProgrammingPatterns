using UnityEngine;

namespace Personal.Patterns.State
{
    public class ConcreteStateB : IState
    {
        public void Enter(Context context)
        {
            Debug.Log("Entered state B!");
            Debug.Log("Press '1' to change to state C.");
            Debug.Log("Press '2' to change to state D.");
        }

        public void Update(Context context)
        {
            if(Input.GetKeyDown(KeyCode.Alpha1))
            {
                context.SetState(context.StateC);
            }
            else if(Input.GetKeyDown(KeyCode.Alpha2))
            {
                context.SetState(context.StateD);
            }
        }

        public void Exit(Context context)
        {
            Debug.Log("Exited state B!");
        }
    }
}