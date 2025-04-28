using UnityEngine;
namespace Sample.Generic
{
    public class GenericDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Cup클래스의 객체 생성
            //Cup cup = new Cup(); 안된다 이거

            //int형 데이터를 저장하는 속성을 가진 객체 생성
            Cup<int> number = new Cup<int>();
            number.Contents = 1234;

            //string형 데이터를 저장하는 속성을 가진 객체 생성
            Cup<string> text = new Cup<string>();
            text.Contents = "문자열 전용 컵";

            Debug.Log($"{number.Contents} - {text.Contents}");

            //물컵 전용
            Cup<Water> water = new Cup<Water>();
            Water water1 = new Water();
            water.Contents = water1;
            Debug.Log(water.Contents);
        }

        
    }
}