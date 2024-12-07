using UnityEngine;

namespace Personal.Patterns.SOLID
{
    public class Circle : Shape
    {
        public float Radius { get; set; }

        public override float GetArea()
        {
            return Radius * Radius * Mathf.PI;
        }
    }
}

