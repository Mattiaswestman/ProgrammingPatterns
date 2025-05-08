using UnityEngine;

namespace Personal.Patterns.SOLID.DependencyInversion
{
    // High level module depends on low level module, breaking the principle.
    public class HighLevelModule_Unrefactored : MonoBehaviour
    {
        private LowLevelModule_Unrefactored _lowLevelModule;

        public void PrintLog()
        {
            if(_lowLevelModule.ShouldPrintLog)
            {
                _lowLevelModule.PrintLog();
            }
        }
    }
}
