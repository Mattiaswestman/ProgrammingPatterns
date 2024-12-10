
namespace Personal.Patterns.SOLID.DependencyInjection
{
    public interface ISwitchable 
    {
        public bool IsActive { get; }

        public void Activate();
        public void Deactivate();
    }
}
