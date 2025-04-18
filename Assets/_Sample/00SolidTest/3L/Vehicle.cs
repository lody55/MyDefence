using UnityEngine;
namespace Solid
{
    public class Vehicle : MonoBehaviour
    {
        #region Field
        public float speed;
        public Vector3 direction;
        #endregion


        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {

        }
        public virtual void GoForward()
        {
            //앞으로 직진 구현
        }

        public virtual void GoBack()
        {
            //뒤로 후진 구현
        }

        public virtual void TurnLeft()
        {
            //좌회전 구현
        }
        public virtual void TurnRight()
        {
            //우회전 구현
        }
    }

    //Vehicle을 상속받는 Car 클래스
    public class Car : Vehicle
    {
        public override void GoForward()
        {
            //자동차 전진
        }
        public override void GoBack()
        {
            //자동차 후진
        }
        public override void TurnLeft()
        {
            //자동차 좌회전
        }
        public override void TurnRight()
        {
            //자동차 우회전
        }
    }
    public class Train : Vehicle
    {
        public override void GoForward()
        {
            //기차가 전진
        }
        public override void GoBack()
        {
            //기차가 후진
        }
        public override void TurnLeft()
        {
            //empty 일부러 구현안하고 메서드만 만듬 만들면안되기 때문
        }
        public override void TurnRight()
        {
            //empty
        }
    }
}