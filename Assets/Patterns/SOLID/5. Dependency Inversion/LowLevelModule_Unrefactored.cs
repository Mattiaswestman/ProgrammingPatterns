using UnityEngine;

namespace Personal.Patterns.SOLID.DependencyInversion
{
    public class LowLevelModule_Unrefactored
    {
        public bool ShouldPrintLog { get; set; }

        public void PrintLog()
        {
            Debug.Log("Log was printed.");
        }
    }
}
