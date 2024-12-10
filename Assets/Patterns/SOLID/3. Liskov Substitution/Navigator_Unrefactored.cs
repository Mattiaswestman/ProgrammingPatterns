
namespace Personal.Patterns.SOLID.LiskovSubstitution
{
    // Imagine a turn-based game where you move the Vehicle along a prescribed path: forward, left, right.

    // The following example violates the Liskov Substitution principle. We cannot substitute the subtype Train
    // for the type Vehicle here.  A train cannot functionally turn left/right.
    public class Navigator_Unrefactored
    {
        public void Move(Vehicle_Unrefactored vehicle)
        {
            vehicle.GoForward();
            vehicle.TurnLeft();
            vehicle.TurnRight();
        }
    }
}
