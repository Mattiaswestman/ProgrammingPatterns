using UnityEngine;

namespace Personal.Patterns.AbstractFactory
{
    // Concrete products are created by corresponding concrete factories.
    public class MinorHealthBoost : IHealthBoost
    {
        public void PrintLog()
        {
            Debug.Log("Created minor health boost!");
        }
    }
}