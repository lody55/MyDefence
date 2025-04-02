using UnityEngine;
namespace Sample
{
    public class PlayerTest : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //static 멤버 변수 사용하기
            //StaticTest.number = 10;
            //Debug.Log($"StaticTest.number : {StaticTest.number}");

            // 싱글톤 클래스 객체 생성 <<<< XX
            // Singleton singleton = new Singleton(); <<<< XX
            // Debug.Log(singleton.ToString());

            // 싱글톤 클래스 호출,접근
            var singletonA = Singleton.Instance;
            var singletonB = Singleton.Instance;
            if(singletonA == singletonB)
            {
                Debug.Log(singletonA.ToString());
            }

             //SingletonTest 클래스 사용하기
             SingletonTset.Instance.number = 99;
             Debug.Log($"SingletonTset.Instance.number : {SingletonTset.Instance.number}");

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}