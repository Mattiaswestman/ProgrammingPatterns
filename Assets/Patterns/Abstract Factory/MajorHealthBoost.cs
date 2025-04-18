using UnityEngine;

namespace Personal.Patterns.AbstractFactory
{
    // Concrete products are created by corresponding concrete factories.
    public class MajorHealthBoost : IHealthBoost
    {
        public void PrintLog()
        {
            Debug.Log("Created major health boost!");
        }
    }
}