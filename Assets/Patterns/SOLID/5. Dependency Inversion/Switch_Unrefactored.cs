using UnityEngine;

namespace Personal.Patterns.SOLID.DependencyInversion
{
    public class Switch_Unrefactored : MonoBehaviour
    {
        public Door_Unrefactored Door { get; set; }
        public bool IsActivated { get; private set; }

        public void Toggle()
        {
            if(IsActivated)
            {
                IsActivated = false;
                Door.Close();
            }
            else
            {
                IsActivated = true;
                Door.Open();
            }
        }
    }
}
