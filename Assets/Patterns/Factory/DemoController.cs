using UnityEngine;

namespace Personal.Patterns.Factory
{
    public class DemoController : MonoBehaviour
    {
        public enum ProductType { A, B }

        [SerializeField]
        private ProductType _productType;

        private Factory _factory;

        private void Awake()
        {
            switch(_productType)
            {
                case ProductType.A:
                {
                    _factory = new ConcreteFactoryA();
                    break;
                }   
                case ProductType.B:
                {
                    _factory = new ConcreteFactoryB();
                    break;
                }
                default:
                {
                    _factory = new ConcreteFactoryA();
                    break;
                }
            }

            Debug.Log("Created factory. Press 'Return' to create product.");
        }

        private void Update()
        {
            if(Input.GetKeyDown(KeyCode.Return))
            {
                IProduct product = _factory.GetProduct();
                product.PrintLog();
            }
        }
    }
}