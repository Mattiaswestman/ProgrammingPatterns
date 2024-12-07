
namespace Personal.Patterns.SOLID
{
    // Imagine a turn-based game where you move the Vehicle along a prescribed path: forward, left, right.

    // The following example follows the Liskov Substitution principle.
    // Here, you can use a Car wherever we use the type RoadVehicle.
    // You can use a Train wherever we use the type RailVehicle.

    // Enforce inheritance hierarchy based on software design, not on real-world analogies.
    public class Navigator
    {
        public void MoveRoadVehicle(RoadVehicle roadVehicle)
        {
            roadVehicle.GoForward();
            roadVehicle.TurnLeft();
            roadVehicle.TurnRight();
        }

        public void MoveRailVehicle(RailVehicle railVehicle)
        {
            railVehicle.GoForward();
            railVehicle.GoForward();
            railVehicle.Reverse();
        }

    }
}
