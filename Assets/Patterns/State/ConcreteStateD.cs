using UnityEngine;

namespace Personal.Patterns.State
{
    public class ConcreteStateD : IState
    {
        public void Enter(Context context)
        {
            Debug.Log("Entered state D!");
            Debug.Log("Press '1' to change to state A.");
        }

        public void Update(Context context)
        {
            if(Input.GetKeyDown(KeyCode.Alpha1))
            {
                context.SetState(context.StateA);
            }
        }

        public void Exit(Context context)
        {
            Debug.Log("Exited state D!");
        }
    }
}