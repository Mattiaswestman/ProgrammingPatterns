using UnityEngine;

namespace Personal.Patterns.SOLID.SingleResponsibility
{
    public class PlayerAudio : MonoBehaviour
    {
        private AudioSource _bounceSfx;

        private void Start()
        {
            _bounceSfx = GetComponent<AudioSource>();
        }

        private void OnTriggerEnter(Collider other)
        {
            _bounceSfx.Play();
        }
    }
}
