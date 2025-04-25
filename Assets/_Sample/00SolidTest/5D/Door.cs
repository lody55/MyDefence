using UnityEngine;
namespace Solid
{
    public class Door : MonoBehaviour, ISwitchable
    {
        private bool isAcive;
        public bool IsActive => isAcive;

        public void Activate()
        {
            isAcive = true;
            Debug.Log("문이 열리는 기능");
        }

        public void Deactivate()
        {
            isAcive = false;
            Debug.Log("문이 닫히는 기능");
        }
    }
}