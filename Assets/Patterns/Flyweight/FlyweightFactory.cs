using System.Collections.Generic;

namespace Personal.Patterns.Flyweight
{
    public static class FlyweightFactory
    {
        private static Dictionary<string, Flyweight> _flyweightDictionary = new Dictionary<string, Flyweight>();

        public static Flyweight GetFlyweight(string color)
        {
            if(!_flyweightDictionary.ContainsKey(color))
            {
                _flyweightDictionary.Add(color, new Flyweight(color));
            }

            return _flyweightDictionary[color];
        }
    }
}