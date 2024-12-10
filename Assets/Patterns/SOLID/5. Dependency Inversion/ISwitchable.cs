
namespace Personal.Patterns.SOLID.DependencyInversion
{
    public interface ISwitchable 
    {
        public bool IsActive { get; }

        public void Activate();
        public void Deactivate();
    }
}
