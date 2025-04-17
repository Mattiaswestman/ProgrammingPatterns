
namespace Personal.Patterns.Factory
{
    // Concrete factories override the factory method to change the resulting product's type.
    public class ConcreteFactoryB : Factory
    {
        public override IProduct GetProduct()
        {
            return new ProductB();
        }
    }
}