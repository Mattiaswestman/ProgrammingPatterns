using UnityEngine;

namespace Personal.Patterns.AbstractFactory
{
    // Concrete products are created by corresponding concrete factories.
    public class MajorDamageBoost : IDamageBoost
    {
        public void PrintLog()
        {
            Debug.Log("Created major damage boost!");
        }
    }
}