
namespace Personal.Patterns.SOLID.InterfaceSegregation
{
    public interface IDamageable 
    {
        public float Health { get; set; }
        public int Defense { get; set; }

        public void TakeDamage();
        public void Die();
        public void RestoreHealth();
    }
}
