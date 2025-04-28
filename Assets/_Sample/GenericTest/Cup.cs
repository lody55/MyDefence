using UnityEngine;
namespace Sample.Generic
{
    public class Water
    {

    }
    public class Cola { }
    public class Coffee { }

    //클래스이름<T> 형태로 제네릭 클래스 정의하기
    public class Cup <T>
    {
        public T Contents { get; set; }

        public void PrintData(T data)
        {
            Debug.Log(data);
        }
    }
}