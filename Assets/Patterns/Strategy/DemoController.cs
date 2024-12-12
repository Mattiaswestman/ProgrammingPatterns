using UnityEngine;

namespace Personal.Patterns.Strategy
{
    // The client code picks a concrete strategy and passes it to the context.
    // The client should be aware of the differences between strategies in order to make the right choice.
    public class DemoController : MonoBehaviour
    {
        private Context _context;

        private void Awake()
        {
            _context = new Context(new StrategyAdd());
        }

        private void Update()
        {
            HandleInput();
        }

        private void HandleInput()
        {
            if(Input.GetKeyDown(KeyCode.Alpha1))
            {
                _context.SetStrategy(new StrategyAdd());
            }
            if(Input.GetKeyDown(KeyCode.Alpha2))
            {
                _context.SetStrategy(new StrategySubtract());
            }
            if(Input.GetKeyDown(KeyCode.Alpha3))
            {
                _context.SetStrategy(new StrategyMultiply());
            }
            if(Input.GetKeyDown(KeyCode.Space))
            {
                int sum = _context.ExecuteStrategy(5, 3);
                Debug.Log("Value: " + sum);
            }
        }
    }
}