using UnityEngine;

namespace Sample
{
    public class ObjectTest : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //this.transform : ObjectTest가 붙어있는 게임오브젝트의 Transform의 객체 
            Debug.Log(this.transform);

            //this.gameObject : ObjectTest가 붙어있는 게임오브젝트의 GameObject의 객체 
            Debug.Log(this.gameObject);

            //this.transform.gameObject == this.gameObject
            //this.gameObject.transform == this.transform 동일함 
        }

       
    }
}