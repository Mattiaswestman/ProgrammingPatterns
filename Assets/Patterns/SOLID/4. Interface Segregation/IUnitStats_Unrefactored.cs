
namespace Personal.Patterns.SOLID.InterfaceSegregation
{
    // Interface Segregation tells us to use smaller interfaces. Rather than adding all of these properties & methods to one interface, use several.
    public interface IUnitStats_Unrefactored
    {
        public float Health { get; set; }
        public int Defense { get; set; }
        public float MoveSpeed { get; set; }
        public float Acceleration { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Endurance { get; set; }
        public float Mass { get; set; }
        public float ExplosiveForce { get; set; }
        public float FuseDelay { get; set; }
        public float Timeout { get; set; }

        public void TakeDamage();
        public void Die();
        public void RestoreHealth();
        public void MoveForward();
        public void Reverse();
        public void TurnLeft();
        public void TurnRight();
        public void Explode();
    }
}
