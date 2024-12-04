using UnityEngine;

namespace Personal.Patterns.Decorator
{
    public class DecoratorHam : Decorator
    {
        public DecoratorHam(IPizza pizza) : base(pizza)
        {
        }

        public override string GetPizzaType()
        {
            string pizzaType = base.GetPizzaType();
            pizzaType += "\nWith ham.";
            return pizzaType;
        }
    }
}