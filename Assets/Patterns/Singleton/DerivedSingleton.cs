using UnityEngine;

namespace Personal.Patterns.Singleton
{
    public class DerivedSingleton : Singleton<DerivedSingleton>
    {
        public int Value { get; private set; }

        public void IncreaseValue()
        {
            Value++;
        }
    }
}