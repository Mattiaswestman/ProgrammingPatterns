using UnityEngine;

namespace Personal.Patterns.SOLID.DependencyInjection
{
    public class Door_Unrefactored : MonoBehaviour
    {
        public void Open()
        {
            Debug.Log("The door is open.");
        }

        public void Close()
        {
            Debug.Log("The door is closed.");
        }
    }
}
