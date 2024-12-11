
namespace Personal.Patterns.SOLID.DependencyInversion
{
    public interface ILowLevelModule 
    {
        public bool ShouldPrintLog { get; set; }

        public void PrintLog();
    }
}
