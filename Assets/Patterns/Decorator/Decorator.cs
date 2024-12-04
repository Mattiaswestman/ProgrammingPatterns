
namespace Personal.Patterns.Decorator
{
    public class Decorator : IBaseInterface
    {
        private IBaseInterface _baseInterface;

        public Decorator(IBaseInterface baseInterface)
        {
            _baseInterface = baseInterface;
        }

        public virtual string GetText()
        {
            return _baseInterface.GetText();
        }
    }
}