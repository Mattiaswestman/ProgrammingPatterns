
namespace Personal.Patterns.Strategy
{
    // Concrete strategies implement the algorithm while following the base strategy interface.
    // The interface makes them interchangeable in the context.
    public class StrategyAdd : IStrategy
    {
        public int Execute(int A, int B)
        {
            return A + B;
        }
    }
}