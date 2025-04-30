
namespace Personal.Patterns.Bridge
{
    public class Square : Shape
    {
        public Square(IColor color) : base(color)
        {
            _color = color;
        }
    }
}