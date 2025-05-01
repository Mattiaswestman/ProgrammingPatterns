using UnityEngine;

namespace Personal.Patterns.Flyweight
{
    public class Context
    {
        private Flyweight _flyweight;
        private int _id;

        public Context(Flyweight flyweight, int id)
        {
            _flyweight = flyweight;
            _id = id;
        }

        public void PrintLog()
        {
            Debug.Log($"Created new Context with color '{_flyweight.Color}' and id '{_id}'.");
        }
    }
}