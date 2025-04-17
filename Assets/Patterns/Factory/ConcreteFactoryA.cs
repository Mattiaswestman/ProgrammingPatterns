
namespace Personal.Patterns.Factory
{
    // Concrete factories override the factory method to change the resulting product's type.
    public class ConcreteFactoryA : Factory
    {
        public override IProduct GetProduct()
        {
            return new ProductA();
        }
    }
}