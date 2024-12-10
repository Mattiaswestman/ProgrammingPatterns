using UnityEngine;

namespace Personal.Patterns.SOLID.DependencyInjection
{
    // New implementation with ISwitchable client.
    public class Switch : MonoBehaviour
    {
        public ISwitchable Switchable { get; set; }

        public void Toggle()
        {
            if (Switchable.IsActive)
            {
                Switchable.Deactivate();
            }
            else
            {
                Switchable.Activate();
            }
        }
    }
}
