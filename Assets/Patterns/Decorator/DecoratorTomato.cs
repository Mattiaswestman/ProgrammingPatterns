using UnityEngine;

namespace Personal.Patterns.Decorator
{
    public class DecoratorTomato : Decorator
    {
        public DecoratorTomato(IPizza pizza) : base(pizza)
        {
        }

        public override string GetPizzaType()
        {
            string pizzaType = base.GetPizzaType();
            pizzaType += "\nWith tomato.";
            return pizzaType;
        }
    }
}