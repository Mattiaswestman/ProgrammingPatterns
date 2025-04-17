using UnityEngine;

namespace Personal.Patterns.Factory
{
    // Concrete products provide various implementations of the product interface.
    public class ProductB : IProduct
    {
        public void PrintLog()
        {
            Debug.Log("Created product B!");
        }
    }
}