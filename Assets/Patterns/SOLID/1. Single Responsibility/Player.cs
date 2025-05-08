using UnityEngine;

namespace Personal.Patterns.SOLID.SingleResponsibility
{
    [RequireComponent(typeof(PlayerAudio), typeof(PlayerInput), typeof(PlayerMovement))]
    public class Player : MonoBehaviour
    {
        [SerializeField]
        private PlayerAudio _playerAudio;
        [SerializeField]
        private PlayerInput _playerInput;
        [SerializeField]
        private PlayerMovement _playerMovement;

        private void Start()
        {
            _playerAudio = GetComponent<PlayerAudio>();
            _playerInput = GetComponent<PlayerInput>();
            _playerMovement = GetComponent<PlayerMovement>();
        }
    }
}
