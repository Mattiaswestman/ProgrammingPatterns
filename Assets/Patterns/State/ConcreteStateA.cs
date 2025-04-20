using UnityEngine;

namespace Personal.Patterns.State
{
    public class ConcreteStateA : IState
    {
        public void Enter(Context context)
        {
            Debug.Log("Entered state A!");
            Debug.Log("Press '1' to change to state B.");
        }

        public void Update(Context context)
        {
            if(Input.GetKeyDown(KeyCode.Alpha1))
            {
                context.SetState(context.StateB);
            }
        }

        public void Exit(Context context)
        {
            Debug.Log("Exited state A!");
        }
    }
}