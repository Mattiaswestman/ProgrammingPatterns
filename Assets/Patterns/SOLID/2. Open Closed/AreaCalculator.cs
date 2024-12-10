
namespace Personal.Patterns.SOLID.OpenClosed
{
    // New implementation using open-closed principle.
    // Let each Shape contain the logic for calculating the area.
    public class AreaCalculator 
    {
        public float GetArea(Shape shape)
        {
            return shape.GetArea();
        }
    }
}  
