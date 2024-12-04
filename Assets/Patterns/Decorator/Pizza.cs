using UnityEngine;

namespace Personal.Patterns.Decorator
{
    public class Pizza : IPizza
    {
        public string GetPizzaType()
        {
            return "This is a normal pizza.";
        }
    }
}