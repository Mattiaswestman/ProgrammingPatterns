
namespace Personal.Patterns.SOLID
{
    public class RailVehicle : IMovable
    {
        public float MoveSpeed { get; set; } = 100f;
        public float Acceleration { get; set; } = 5f;
        public float TurnSpeed { get; set; } = 5f;
        public string Name { get; set; }

        public virtual void GoForward()
        {
        }

        public virtual void Reverse()
        {
        }
    }
}
