using UnityEngine;
namespace Solid.Interface
{
    public class EnemyUnit : MonoBehaviour, IDamageable, IMoveable, IStats
    {
        public float Health { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public int Defence { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public float MoveSpeed { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public float Accelation { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public int Strength { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public int Dextrrty { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public int Endurance { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public void Die()
        {
            throw new System.NotImplementedException();
        }

        public void GoBack()
        {
            throw new System.NotImplementedException();
        }

        public void GoForward()
        {
            throw new System.NotImplementedException();
        }

        public void RestoreHealth(float amount)
        {
            throw new System.NotImplementedException();
        }

        public void TakeDamage(float damage)
        {
            throw new System.NotImplementedException();
        }

        public void TurnLeft()
        {
            throw new System.NotImplementedException();
        }

        public void TurnRight()
        {
            throw new System.NotImplementedException();
        }
    }
}