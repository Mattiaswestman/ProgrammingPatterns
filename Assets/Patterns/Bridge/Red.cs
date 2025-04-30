using UnityEngine;

namespace Personal.Patterns.Bridge
{
    public class Red : IColor
    {
        public void PrintLog()
        {
            Debug.Log("This shape has the red color.");
        }
    }
}