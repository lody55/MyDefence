using UnityEngine;
namespace Solid
{
    public class Robot : MonoBehaviour, ISwitchable
    {
        private bool isActive;
        public bool IsActive => isActive;


        public void Activate()
        {
            isActive = true;
            //로봇 켜짐 기능
            Debug.Log("로봇 기동");
        }

        public void Deactivate()
        {
            isActive = false;
            //로봇 꺼짐 기능
            Debug.Log("로봇 꺼짐");
        }
    }
}