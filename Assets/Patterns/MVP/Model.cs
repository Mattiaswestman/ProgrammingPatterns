using System;
using UnityEngine;

namespace Personal.Patterns.MVP
{
    public class Model : MonoBehaviour
    {
        public event Action OnValueChanged;
        public int Value { get; private set; } = 0;

        public void IncrementValue()
        {
            Value++;
            OnValueChanged?.Invoke();
        }
    }
}