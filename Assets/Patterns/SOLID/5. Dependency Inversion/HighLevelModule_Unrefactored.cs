using UnityEngine;

namespace Personal.Patterns.SOLID.DependencyInversion
{
    // High level module depends on low level module, breaking the principle.
    public class HighLevelModule_Unrefactored : MonoBehaviour
    {
        public LowLevelModule_Unrefactored LowLevelModule { get; set; }

        public void PrintLog()
        {
            if(LowLevelModule.ShouldPrintLog)
            {
                LowLevelModule.PrintLog();
            }
        }
    }
}
