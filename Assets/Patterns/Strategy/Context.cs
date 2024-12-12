
namespace Personal.Patterns.Strategy
{
    // The context defines the interface of interest to clients.
    public class Context
    {
        private IStrategy _strategy;

        public Context(IStrategy strategy)
        {
            SetStrategy(strategy);
        }

        public void SetStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public int ExecuteStrategy(int A, int B)
        {
            return _strategy.Execute(A, B);
        }
    }
}