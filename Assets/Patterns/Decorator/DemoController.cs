using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Personal.Patterns.Decorator
{
    public class DemoController : MonoBehaviour
    {
        [SerializeField]
        private bool _useTomatoDecorator;
        [SerializeField]
        private bool _useCheeseDecorator;
        [SerializeField]
        private bool _useHamDecorator;

        private IPizza _pizza;

        private void Awake()
        {
            _pizza = new Pizza();
            if(_useTomatoDecorator)
            {
                _pizza = new DecoratorTomato(_pizza);
            }
            if(_useCheeseDecorator)
            {
                _pizza = new DecoratorCheese(_pizza);
            }
            if(_useHamDecorator)
            {
                _pizza = new DecoratorHam(_pizza);
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
                Debug.Log(_pizza.GetPizzaType());
            }
        }
    }
}