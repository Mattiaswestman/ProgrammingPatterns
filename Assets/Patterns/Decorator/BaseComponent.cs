
namespace Personal.Patterns.Decorator
{
    public class BaseComponent : IBaseInterface
    {
        public string GetText()
        {
            return "This is a base component.";
        }
    }
}