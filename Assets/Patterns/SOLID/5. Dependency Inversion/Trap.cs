using UnityEngine;

namespace Personal.Patterns.SOLID.DependencyInjection
{
    // Revised implementation with ISwitchable.
    public class Trap : MonoBehaviour, ISwitchable
    {
        public bool IsActive { get; private set; }

        public void Activate()
        {
            IsActive = true;
            Debug.Log("The trap is active.");
        }

        public void Deactivate()
        {
            IsActive = false;
            Debug.Log("The trap is inactive.");
        }
    }
}
