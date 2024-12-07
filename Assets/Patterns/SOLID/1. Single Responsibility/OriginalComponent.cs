using UnityEngine;

namespace Personal.Patterns.SOLID
{
    [RequireComponent(typeof(AudioComponent), typeof(InputComponent), typeof(MovementComponent))]
    public class OriginalComponent : MonoBehaviour
    {
        [SerializeField]
        private AudioComponent _audioComponent;
        [SerializeField]
        private InputComponent _inputComponent;
        [SerializeField]
        private MovementComponent _movementComponent;

        private void Start()
        {
            _audioComponent = GetComponent<AudioComponent>();
            _inputComponent = GetComponent<InputComponent>();
            _movementComponent = GetComponent<MovementComponent>();
        }
    }


}
