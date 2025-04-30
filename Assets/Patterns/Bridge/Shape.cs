
namespace Personal.Patterns.Bridge
{
    public class Shape
    {
        protected IColor _color;

        public Shape(IColor color)
        {
            _color = color;
        }

        public void PrintColorLog()
        {
            _color.PrintLog();
        }
    }
}