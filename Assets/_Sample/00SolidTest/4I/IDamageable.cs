using UnityEngine;
namespace Solid.Interface
{
    //helth을 가지고 전투하는 Unit
    public interface IDamageable
    {
        public float Health { get; set; }
        public int Defence { get; set; }
        public void TakeDamage(float damage);

        public void Die();
        public void RestoreHealth(float amount);
    }
}