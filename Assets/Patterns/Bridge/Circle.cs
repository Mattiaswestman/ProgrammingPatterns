
namespace Personal.Patterns.Bridge
{
    public class Circle : Shape
    {
        public Circle(IColor color) : base(color)
        {
            _color = color;
        }
    }
}