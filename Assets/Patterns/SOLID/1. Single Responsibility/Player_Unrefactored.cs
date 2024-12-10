using UnityEngine;

namespace Personal.Patterns.SOLID.SingleResponsibility
{
    // Even though this class is short, it violates single-responsibility.
    // Too many things will cause the class to update, and extending the class will be more difficult.
    public class Player_Unrefactored : MonoBehaviour
    {
        [SerializeField] 
        private string _inputAxisName;
        [SerializeField] 
        private float _positionMultiplier;

        private AudioSource _bounceSfx;
        private float _yPosition;

        private void Start()
        {
            _bounceSfx = GetComponent<AudioSource>();
        }

        private void Update()
        {
            float delta = Input.GetAxis(_inputAxisName) * Time.deltaTime;
            _yPosition = Mathf.Clamp(_yPosition + delta, -1, 1);
            transform.position = new Vector3(transform.position.x, _yPosition * _positionMultiplier, transform.position.z);
        }

        private void OnTriggerEnter(Collider other)
        {
            _bounceSfx.Play();
        }
    }

}
