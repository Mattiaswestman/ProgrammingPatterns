
namespace Personal.Patterns.SOLID
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
