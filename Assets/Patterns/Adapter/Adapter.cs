
namespace Personal.Patterns.Adapter
{
    public class Adapter : IAdapter
    {
        private ThirdPartyCode _thirdPartyCode;

        public Adapter(ThirdPartyCode thirdPartyCode)
        {
            _thirdPartyCode = thirdPartyCode;
        }

        public float GetCelsius()
        {
            return (_thirdPartyCode.GetFahrenheit() - 32) * 5 / 9;
        }

        public void SetCelsius(float value)
        {
            float fahrenheit = (value * 9 / 5) + 32;
            _thirdPartyCode.SetFahrenheit(fahrenheit);
        }
    }
}