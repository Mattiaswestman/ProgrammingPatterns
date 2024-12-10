using UnityEngine;

namespace Personal.Patterns.SOLID.DependencyInjection
{
    // Revised implementation with ISwitchable.
    public class Door : MonoBehaviour, ISwitchable
    {
        public bool IsActive { get; private set; }

        public void Activate()
        {
            IsActive = true;
            Debug.Log("The door is open.");
        }

        public void Deactivate()
        {
            IsActive = false;
            Debug.Log("The door is closed.");
        }
    }

}
