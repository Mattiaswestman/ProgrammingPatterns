using UnityEngine;

namespace Personal.Patterns.AbstractFactory
{
    // Concrete products are created by corresponding concrete factories.
    public class MinorDamageBoost : IDamageBoost
    {
        public void PrintLog()
        {
            Debug.Log("Created minor damage boost!");
        }
    }
}