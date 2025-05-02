using UnityEngine;

namespace Personal.Patterns.Adapter
{
    public class DemoController : MonoBehaviour
    {
        [SerializeField]
        private Service _service;
        [SerializeField]
        private float _celsius;

        private IAdapter _adapter;

        private void Awake()
        {
            _celsius = 10f;
            _adapter = new Adapter(_service);
            _adapter.SetCelsius(_celsius);

            Debug.Log("Press '1' to adapt celsius value in DemoController to fahrenheit.");
            Debug.Log("Press '2' to adapt fahrenheit value in Service to celsius.");
        }

        private void Update()
        {
            if(Input.GetKeyDown(KeyCode.Alpha1))
            {
                _celsius = _adapter.GetCelsius();
                Debug.Log($"Celsius set to '{_celsius}'");
            }
            else if(Input.GetKeyDown(KeyCode.Alpha2))
            {
                _adapter.SetCelsius(_celsius);
            }
        }
    }
}