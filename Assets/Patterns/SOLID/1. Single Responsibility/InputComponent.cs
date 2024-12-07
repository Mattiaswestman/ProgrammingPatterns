using UnityEngine;

namespace Personal.Patterns.SOLID
{
    public class InputComponent : MonoBehaviour
    {
        [SerializeField]
        private string _inputAxisName;

        private void Update()
        {
            float delta = Input.GetAxis(_inputAxisName) * Time.deltaTime;
        }
    }
}
