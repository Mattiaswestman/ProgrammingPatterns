using UnityEngine;

namespace Personal.Patterns.SOLID.DependencyInversion
{
    // High level module no longer depends on a concrete implementation. It instead depends on an interface.
    public class HighLevelModule : MonoBehaviour
    {
        public ILowLevelModule LowLevelModule { get; set; }

        public void PrintLog()
        {
            if(LowLevelModule.ShouldPrintLog)
            {
                LowLevelModule.PrintLog();
            }
        }
    }
}
