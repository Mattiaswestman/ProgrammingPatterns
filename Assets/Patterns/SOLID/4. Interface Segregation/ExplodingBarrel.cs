using UnityEngine;

namespace Personal.Patterns.SOLID.InterfaceSegregation
{
    // Using Interface Segregation, we only implement what interfaces apply.
    public class ExplodingBarrel : MonoBehaviour, IDamageable, IExplodable
    {
        public float Health { get; set; }
        public int Defense { get; set; }
        public float Mass { get; set; }
        public float ExplosiveForce { get; set; }
        public float FuseDelay { get; set; }
        public float Timeout { get; set; }

        public void TakeDamage()
        {
        }

        public void Die()
        {
        }

        public void RestoreHealth()
        {
        }

        public void Explode()
        {
        }
    }
}
