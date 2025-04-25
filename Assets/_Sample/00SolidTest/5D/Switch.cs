using UnityEngine;
using UnityEngine.UI;
namespace Solid
{
    public class Switch : MonoBehaviour
    {
        //public Door door;
        //public Robot robot;

        private ISwitchable client;  //Door, Robot
        [SerializeField]private Transform switchTransform;

        private void Start()
        {
            client = switchTransform.GetComponent<ISwitchable>();
            Debug.Log(client);
        }

        public void Toggle()
        {
            if(client.IsActive)
            {
                client.Deactivate();
            }
            else
            {
                client.Activate();
            }

        }
    }
}