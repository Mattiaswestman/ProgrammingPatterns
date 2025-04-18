
namespace Personal.Patterns.Factory
{
    // Concrete factories override the factory method to change the resulting product's type.
    // If a MonoBehaviour is created, the concrete factories would include a reference to the prefab and code to instantiate the gameobject.
    public class ConcreteFactoryA : Factory
    {
        public override IProduct GetProduct()
        {
            return new ProductA();
        }
    }
}