using UnityEngine;

namespace Personal.Patterns.SOLID
{
    public class AudioComponent : MonoBehaviour
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
