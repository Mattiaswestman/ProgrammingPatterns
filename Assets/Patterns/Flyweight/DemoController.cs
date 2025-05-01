using System.Collections.Generic;
using UnityEngine;

namespace Personal.Patterns.Flyweight
{
    public class DemoController : MonoBehaviour
    {
        [SerializeField]
        private List<Context> _contexts;

        private string[] _colors;

        private void Awake()
        {
            _contexts = new List<Context>();
            _colors = new string[3] { "Blue", "Red", "Green" };

            Debug.Log("Press 'Return' to create objects and print logs.");
        }

        private void Update()
        {
            if(Input.GetKeyDown(KeyCode.Return))
            {
                for(int i = 0; i < 1000; i++)
                {
                    string color = _colors[Random.Range(0, _colors.Length)];
                    int id = Random.Range(0, 1000);
                    var context = new Context(FlyweightFactory.GetFlyweight(color), id);
                    _contexts.Add(context);
                    context.PrintLog();
                }
            }
        }
    }
}