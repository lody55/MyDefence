using UnityEngine;
namespace Sample.Generic
{
    public class SingletonTest : MonoBehaviour
    {
        private void Start()
        {
            //SingletonManager 접근하기
            SingletonManager.Instance.number = 3456;
            Debug.Log(SingletonManager.Instance.number.ToString());
        }
    }
}