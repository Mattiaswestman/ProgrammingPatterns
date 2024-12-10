using UnityEngine;

namespace Personal.Patterns.SOLID.SingleResponsibility
{
    public class PlayerInput : MonoBehaviour
    {
        [SerializeField]
        private string _inputAxisName;

        private void Update()
        {
            float delta = Input.GetAxis(_inputAxisName) * Time.deltaTime;
        }
    }
}
