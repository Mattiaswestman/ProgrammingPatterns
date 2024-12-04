using UnityEngine;

namespace Personal.Patterns.Decorator
{
    public class DecoratorB : Decorator
    {
        public DecoratorB(IBaseInterface baseInterface) : base(baseInterface)
        {
        }

        public override string GetText()
        {
            string text = base.GetText();
            text += "\nWith decorator B.";
            return text;
        }
    }
}