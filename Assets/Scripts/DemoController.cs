using UnityEngine;

namespace Personal.Patterns
{
    public class DemoController : MonoBehaviour
    {
        private void Update()
        {
            HandleInput();
        }

        private void HandleInput()
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                DerivedSingleton.Instance.IncreaseValue();
                Debug.Log($"Singleton value: {DerivedSingleton.Instance.Value}");
            }
        }
    }
}