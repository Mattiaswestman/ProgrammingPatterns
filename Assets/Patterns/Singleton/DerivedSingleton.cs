using UnityEngine;

namespace Personal.Patterns
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