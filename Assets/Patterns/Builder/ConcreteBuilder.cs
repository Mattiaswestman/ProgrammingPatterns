using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Personal.Patterns.Builder
{
    public class ConcreteBuilder : IBuilder
    {
        private Product _product;

        public ConcreteBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            _product = new Product();
        }

        public Product GetResult()
        {
            Product product = _product;
            Reset();
            return product;
        }

        public void BuildStepA(string value)
        {
            _product.SetString(value);
        }

        public void BuildStepB(int value)
        {
            _product.SetInt(value);
        }

        public void BuildStepC(bool value)
        {
            _product.SetBool(value);
        }
    }
}