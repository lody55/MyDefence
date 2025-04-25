using System.Collections;
using UnityEngine;
namespace Sample
{
    public class CoroutineTest : MonoBehaviour
    {
        private bool isCorou = false;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Debug.Log("스타트");
        }

        // Update is called once per frame
        void Update()
        {
            if (isCorou == false)
            {
                Debug.Log("업데이트");
                StartCoroutine(CorouTest());
                
            }
            Debug.Log("업2");

        }

        IEnumerator CorouTest()
        {

            isCorou = true;
            Debug.Log("코1");
            for (int i = 0; i < 3; i++)
            {
                yield return new WaitForSeconds(0.1f);
                Debug.Log($"코2 {i}");
            }
            Debug.Log("코3");
            
        }
    }
}