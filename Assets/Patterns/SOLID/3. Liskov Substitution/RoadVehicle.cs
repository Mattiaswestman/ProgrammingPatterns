
namespace Personal.Patterns.SOLID
{
    public class RoadVehicle : IMovable, ITurnable
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

        public virtual void TurnLeft()
        {
        }

        public virtual void TurnRight()
        {
        }
    }
}
