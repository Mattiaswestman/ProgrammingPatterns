using UnityEngine;

namespace Personal.Patterns.Decorator
{
    public class Decorator : IPizza
    {
        private IPizza _pizza;

        public Decorator(IPizza pizza)
        {
            _pizza = pizza;
        }

        public virtual string GetPizzaType()
        {
            return _pizza.GetPizzaType();
        }
    }
}