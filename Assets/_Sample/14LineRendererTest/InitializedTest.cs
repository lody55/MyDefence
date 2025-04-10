using UnityEngine;

namespace Sample
{
    public class InitializedTest : MonoBehaviour
    {
        //필드에 변수선언 후 초기화
        [SerializeField] private int number = 10;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //start 메서드에서 초기화
            number = 20;
        }

        private void Update()
        {
            Debug.Log($"number : {number}");
        }

    }
}
/*
 필드 초기화 순서
1. 필드 변수선언 값
2. 인스펙터(직렬화) 변수 값
3. start함수 변수 초기화 값
 */