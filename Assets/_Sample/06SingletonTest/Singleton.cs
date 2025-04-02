using UnityEngine;
namespace Sample
{
    //싱글톤 패턴 클래스
    public class Singleton
    {
        ////클래스의 객체를 정적(static) 변수 선언
        private static Singleton instance;

        public static Singleton Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }

        ////public한 메서드로 instance 전역적으로 접근하기
        //public static Singleton Instance()
        //{
        //    if(instance ==null)
        //    {
        //        instance = new Singleton();
        //    }
        //    return instance;
        //}


        //기본 생성자(생략가능)
        //public Singleton()
        //{

        //}


    }
}

/*
 싱글톤 패턴 클래스
- 하나의 객체만 존재 : new를 1번만 호출
- 클래스의 객체가 전역적 접근 가능 : 변수를 static 선언

 */