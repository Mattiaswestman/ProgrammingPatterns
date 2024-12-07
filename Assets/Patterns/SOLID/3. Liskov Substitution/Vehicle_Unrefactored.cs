
namespace Personal.Patterns.SOLID
{
    // Don't include this in a base class, use composition instead of inheritance.
    // We put the functionality instead into the ITurnable and IMovable interfaces.
    // The RailVehicle and RoadVehicle classes can then implement only what they need.
    public class Vehicle_Unrefactored
    {
        public float MoveSpeed { get; set; } = 100f;
        public float Acceleration { get; set; } = 5f;
        public float TurnSpeed { get; set; } = 5f;
        public string Name { get; set; }

        public void GoForward()
        {
        }

        public void Reverse()
        {
        }

        public void TurnRight()
        {
        }

        public void TurnLeft()
        {
        }
    }
}
