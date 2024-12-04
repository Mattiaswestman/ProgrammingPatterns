
namespace Personal.Patterns.Decorator
{
    public class DecoratorC : Decorator
    {
        public DecoratorC(IBaseInterface baseInterface) : base(baseInterface)
        {
        }

        public override string GetText()
        {
            string text = base.GetText();
            text += "\nWith decorator C.";
            return text;
        }
    }
}