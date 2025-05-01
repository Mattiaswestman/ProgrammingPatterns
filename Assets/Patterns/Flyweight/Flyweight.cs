
namespace Personal.Patterns.Flyweight
{
    public class Flyweight
    {
        public string Color { get; private set; }

        public Flyweight(string color)
        {
            Color = color;
        }
    }
}