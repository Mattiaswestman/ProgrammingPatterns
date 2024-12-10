
namespace Personal.Patterns.SOLID.InterfaceSegregation
{
    public interface IMovable
    {
        public float MoveSpeed { get; set; }
        public float Acceleration { get; set; }

        public void MoveForward();
        public void Reverse();
        public void TurnLeft();
        public void TurnRight();
    }
}
