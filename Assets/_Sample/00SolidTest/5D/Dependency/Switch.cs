using UnityEngine;
namespace Solid.Dependency
{
    public class Switch : MonoBehaviour
    {

        public Door door;
        public Trap trap;
        private bool isActivated = false;

        //한번 누르면 문이열리고 다시 한번 누르면 문이 닫힌다
        public void Toggle()
        {
            if(isActivated)
            {
                isActivated = false;
                //door.Close();
                
                //trap.TrapDisable();

            }
            else
            {
                isActivated = true;
                //door.Open();

                //trap.TrapEnable();
            }
        }
    }
}