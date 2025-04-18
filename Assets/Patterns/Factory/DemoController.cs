using UnityEngine;

namespace Personal.Patterns.Factory
{
    public class DemoController : MonoBehaviour
    {
        private Factory _factory;

        private void Awake()
        {
            _factory = new ConcreteFactoryA();

            Debug.Log("Press '1' to set concrete factory A.");
            Debug.Log("Press '2' to set concrete factory B.");
            Debug.Log("Press '3' to create product.");
        }

        private void Update()
        {
            if(Input.GetKeyDown(KeyCode.Alpha1))
            {
                _factory = new ConcreteFactoryA();
            }
            else if(Input.GetKeyDown(KeyCode.Alpha2))
            {
                _factory = new ConcreteFactoryB();
            }
            else if(Input.GetKeyDown(KeyCode.Alpha3))
            {
                IProduct product = _factory.GetProduct();
                product.PrintLog();
            }
        }
    }
}