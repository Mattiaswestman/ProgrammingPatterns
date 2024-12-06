using System;
using UnityEngine;

namespace Personal.Patterns.MVP
{
    public class Model : MonoBehaviour
    {
        public event Action ValueChanged;
        public int Value { get; private set; } = 0;

        public void IncrementValue()
        {
            Value++;
            UpdateValue();
        }

        private void UpdateValue()
        {
            ValueChanged?.Invoke();
        }
    }
}