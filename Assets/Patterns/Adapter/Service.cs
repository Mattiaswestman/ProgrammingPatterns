using UnityEngine;

namespace Personal.Patterns.Adapter
{
    public class Service : MonoBehaviour
    {
        [SerializeField]
        private float _fahrenheit;

        public float GetFahrenheit()
        {
            return _fahrenheit;
        }

        public void SetFahrenheit(float value)
        {
            _fahrenheit = value;
            Debug.Log($"Fahrenheit set to '{_fahrenheit}'");
        }
    }
}