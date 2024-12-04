using UnityEngine;

namespace Personal.Patterns.Decorator
{
    public class DecoratorCheese : Decorator
    {
        public DecoratorCheese(IPizza pizza) : base(pizza)
        {
        }

        public override string GetPizzaType()
        {
            string pizzaType = base.GetPizzaType();
            pizzaType += "\nWith cheese.";
            return pizzaType;
        }
    }
}