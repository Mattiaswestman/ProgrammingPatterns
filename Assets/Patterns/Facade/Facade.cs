using UnityEngine;

namespace Personal.Patterns.Facade
{
    public class Facade : IFacade
    {
        private readonly ThirdPartyCode _thirdPartyCode;

        public Facade(ThirdPartyCode thirdPartyCode)
        {
            _thirdPartyCode = thirdPartyCode;
        }

        public void MethodA()
        {
            _thirdPartyCode.MethodA();
        }
    }
}