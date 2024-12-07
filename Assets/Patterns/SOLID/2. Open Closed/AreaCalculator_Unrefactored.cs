using UnityEngine;

namespace Personal.Patterns.SOLID
{
    // Old implemenation not using open-closed principle.
    public class AreaCalculator_Unrefactored
    {
        public float GetRectangleArea(Rectangle rectangle)
        {
            return rectangle.Width * rectangle.Height;
        }

        public float GetCircleArea(Circle circle)
        {
            return circle.Radius * circle.Radius * Mathf.PI;
        }
    }
}
