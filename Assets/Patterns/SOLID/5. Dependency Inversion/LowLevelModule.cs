using UnityEngine;

namespace Personal.Patterns.SOLID.DependencyInversion
{
    // Low level module depends on an interface.
    public class LowLevelModule : ILowLevelModule
    {
        public bool ShouldPrintLog { get; set; }

        public void PrintLog()
        {
            Debug.Log("Log was printed.");
        }
    }

}
