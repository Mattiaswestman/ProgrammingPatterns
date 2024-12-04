
namespace Personal.Patterns.Decorator
{
    public class DecoratorA : Decorator
    {
        public DecoratorA(IBaseInterface baseInterface) : base(baseInterface)
        {
        }

        public override string GetText()
        {
            string text = base.GetText();
            text += "\nWith decorator A.";
            return text;
        }
    }
}