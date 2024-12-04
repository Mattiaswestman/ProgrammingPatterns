using UnityEngine;

namespace Personal.Patterns.Decorator
{
    public class DemoController : MonoBehaviour
    {
        [SerializeField]
        private bool _useDecoratorA;
        [SerializeField]
        private bool _useDecoratorB;
        [SerializeField]
        private bool _useDecoratorC;

        private IBaseInterface _baseInterface;

        private void Awake()
        {
            _baseInterface = new BaseComponent();
            if(_useDecoratorA)
            {
                _baseInterface = new DecoratorA(_baseInterface);
            }
            if(_useDecoratorB)
            {
                _baseInterface = new DecoratorB(_baseInterface);
            }
            if(_useDecoratorC)
            {
                _baseInterface = new DecoratorC(_baseInterface);
            }
        }

        private void Update()
        {
            HandleInput();
        }

        private void HandleInput()
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log(_baseInterface.GetText());
            }
        }
    }
}