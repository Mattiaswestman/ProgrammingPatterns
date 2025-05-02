
namespace Personal.Patterns.Adapter
{
    public class Adapter : IAdapter
    {
        private readonly Service _service;

        public Adapter(Service service)
        {
            _service = service;
        }

        public float GetCelsius()
        {
            return (_service.GetFahrenheit() - 32) * 5 / 9;
        }

        public void SetCelsius(float value)
        {
            float fahrenheit = (value * 9 / 5) + 32;
            _service.SetFahrenheit(fahrenheit);
        }
    }
}