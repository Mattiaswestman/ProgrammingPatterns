
namespace Personal.Patterns.AbstractFactory
{
    // Concrete factories produce a family of products that belong to a single variant. The factory guarantees that the resulting products are compatible.
    // If a MonoBehaviour is created, the concrete factories would include a reference to the prefab and code to instantiate the gameobject.
    public class MajorItemFactory : IAbstractFactory
    {
        public IHealthBoost GetHealthBoost()
        {
            return new MajorHealthBoost();
        }

        public IDamageBoost GetDamageBoost()
        {
            return new MajorDamageBoost();
        }
    }
}