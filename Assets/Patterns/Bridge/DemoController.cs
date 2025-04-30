using UnityEngine;

namespace Personal.Patterns.Bridge
{
    public class DemoController : MonoBehaviour
    {
        private Circle _circle;
        private Square _square;
        private Shape _activeShape;

        private void Awake()
        {
            _circle = new Circle(new Red());
            _square = new Square(new Blue());
            _activeShape = _circle;

            Debug.Log("Press '1' to use the circle shape and '2' to use the square shape.");
            Debug.Log("Press '3' to print the color of the active shape.");
        }

        private void Update()
        {
            if(Input.GetKeyDown(KeyCode.Alpha1))
            {
                _activeShape = _circle;
                Debug.Log("Changed to circle shape.");
            }
            else if(Input.GetKeyDown(KeyCode.Alpha2))
            {
                _activeShape = _square;
                Debug.Log("Changed to square shape.");
            }
            else if(Input.GetKeyDown(KeyCode.Alpha3))
            {
                _activeShape.PrintColorLog();
            }
        }
    }
}