using UnityEngine;

namespace Personal.Patterns.Proxy
{
    public class DemoController : MonoBehaviour
    {
        [SerializeField]
        private Service _service;

        private IServiceInterface _proxy;

        private void Awake()
        {
            _proxy = new Proxy(_service);

            Debug.Log("Press 'Return' to try and access Service to print log.");
        }

        private void Update()
        {
            if(Input.GetKeyDown(KeyCode.Return))
            {
                _proxy.PrintLog();
            }
        }
    }
}