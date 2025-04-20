using UnityEngine;

namespace Personal.Patterns.State
{
    public class Context : MonoBehaviour
    {
        public IState StateA { get; private set; }
        public IState StateB { get; private set; }
        public IState StateC { get; private set; }
        public IState StateD { get; private set; }

        private IState _currentState;

        private void Awake()
        {
            StateA = new ConcreteStateA();
            StateB = new ConcreteStateB();
            StateC = new ConcreteStateC();
            StateD = new ConcreteStateD();

            SetState(StateA);
        }

        private void Update()
        {
            _currentState?.Update(this);
        }

        public void SetState(IState state)
        {
            _currentState?.Exit(this);
            _currentState = state;
            _currentState?.Enter(this);
        }
    }
}