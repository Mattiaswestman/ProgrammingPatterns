
namespace Personal.Patterns.Strategy
{
    // The strategy interface declares operations common to all supported versions of some algorithm.
    // The context uses this interface to call the algorithm defined by the concrete strategies.
    public interface IStrategy
    {
        public int Execute(int A, int B);
    }
}