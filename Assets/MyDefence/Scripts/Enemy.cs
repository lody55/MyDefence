using UnityEngine;
namespace MyDefence
{
    public class Enemy : MonoBehaviour
    {
        //필드
        #region Field
        private float speed = 5f;
        private Vector3 targetPosition;
        private int wayPointIndex = 0;
        #endregion

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //초기화
            targetPosition = WayPoints.wayPoints[wayPointIndex].position;

        }

        // Update is called once per frame
        void Update()
        {
            //이동 구현
            Vector3 dir = targetPosition - this.transform.position;
            transform.Translate(dir.normalized * Time.deltaTime * speed,Space.World);

            //targetPosition 도착 판정
            float distance = Vector3.Distance(targetPosition, this.transform.position);
            if (distance <= 0.2f)
            {
                Debug.Log("도착");
                //다음 타겟 셋팅
                wayPointIndex++; // 다음 웨이포인트로 이동

                // 웨이포인트가 남아있다면 이동
                if (wayPointIndex < WayPoints.wayPoints.Length)
                {
                    targetPosition = WayPoints.wayPoints[wayPointIndex].position;
                }
                else
                {
                    Debug.Log("목표 지점 도달 - 이동 종료");
                    enabled = false; // Update 비활성화 (이동 멈춤)
                }

            }


        }
    }
}