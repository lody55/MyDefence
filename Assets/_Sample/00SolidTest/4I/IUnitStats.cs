using UnityEngine;
namespace Solid.Interface
{
    //이런식으로 모든 기능을 정의하면 안된다xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
    public interface IUnitStats
    {
        public float Health { get; set; }
        public int Defence { get; set; }
        public void TakeDamage(float damage);

        public void Die();
        public void RestoreHealth(float amount);

        public float MoveSpeed { get; set; }
        public float Accelation { get; set; }
        public void GoForward();
        public void GoBack();
        public void TurnLeft();
        public void TurnRight();
        public int Strength { get; set; }
        public int Dextrrty { get; set; }
        public int Endurance { get; set; }
   
    }
    

}