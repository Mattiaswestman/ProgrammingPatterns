using UnityEngine;

namespace Personal.Patterns.Facade
{
    public class DemoController : MonoBehaviour
    {
        [SerializeField]
        private Service _service;

        private IFacade _facade;

        private void Awake()
        {
            _facade = new Facade(_service);

            Debug.Log("Press 'Return' to call method A through the facade.");
        }

        private void Update()
        {
            if(Input.GetKeyDown(KeyCode.Return))
            {
                _facade.MethodA();
            }
        }
    }
}