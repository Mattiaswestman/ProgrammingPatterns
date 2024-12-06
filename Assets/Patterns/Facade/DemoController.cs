using UnityEngine;

namespace Personal.Patterns.Facade
{
    public class DemoController : MonoBehaviour
    {
        [SerializeField]
        private ThirdPartyCode _thirdPartyCode;

        private IFacade _facade;

        private void Awake()
        {
            _facade = new Facade(_thirdPartyCode);
        }

        private void Start()
        {
            _facade.MethodA();
        }
    }
}