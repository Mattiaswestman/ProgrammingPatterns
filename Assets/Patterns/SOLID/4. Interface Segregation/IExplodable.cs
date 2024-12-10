
namespace Personal.Patterns.SOLID.InterfaceSegregation
{
    public interface IExplodable
    {
        public float Mass { get; set; }
        public float ExplosiveForce { get; set; }
        public float FuseDelay { get; set; }
        public float Timeout { get; set; }

        public void Explode();
    }
}
