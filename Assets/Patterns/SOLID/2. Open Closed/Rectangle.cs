
namespace Personal.Patterns.SOLID.OpenClosed
{
    public class Rectangle : Shape
    {
        public float Width { get; set; }
        public float Height { get; set; }

        public override float GetArea()
        {
            return Width * Height;
        }
    }
}
