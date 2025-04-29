using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Personal.Patterns.Builder
{
    public class DemoController : MonoBehaviour
    {
        private Director _director;

        private void Awake()
        {
            _director = new Director();

            Debug.Log("Press '1' to build with Director.");
            Debug.Log("Press '2' to build with Builder.");
        }

        private void Update()
        {
            if(Input.GetKeyDown(KeyCode.Alpha1))
            {
                ConcreteBuilder builder = new ConcreteBuilder();
                _director.Build(builder);
                Product product = builder.GetResult();

                product.PrintLog();
            }
            else if(Input.GetKeyDown(KeyCode.Alpha2))
            {
                ConcreteBuilder builder = new ConcreteBuilder();
                builder.BuildStepA("Builder string");
                builder.BuildStepB(4);
                builder.BuildStepC(false);
                Product product = builder.GetResult();

                product.PrintLog();
            }
        }
    }
}