using UnityEngine;

namespace Personal.Patterns.Factory
{
    // Concrete products provide various implementations of the product interface.
    public class ProductA : IProduct
    {
        public void PrintLog()
        {
            Debug.Log("Created product A!");
        }
    }
}