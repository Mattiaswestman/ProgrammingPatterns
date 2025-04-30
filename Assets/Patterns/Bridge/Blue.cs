using UnityEngine;

namespace Personal.Patterns.Bridge
{
    public class Blue : IColor
    {
        public void PrintLog()
        {
            Debug.Log("This shape has the blue color.");
        }
    }
}