using UnityEngine;

namespace Personal.Patterns.Factory
{
    // The factory class declares the factory method that must return an object of a product class.
    // The factory's subclasses usually provide the implementation of this method.
    public abstract class Factory
    {
        public abstract IProduct GetProduct();
    }
}