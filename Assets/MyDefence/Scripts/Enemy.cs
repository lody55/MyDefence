using UnityEngine;
namespace MyDefence
{
    public class Enemy : MonoBehaviour
    {
        //필드
        #region Field
        [SerializeField]
        private float speed = 5f;
        private Vector3 targetPosition;     
        private int wayPointIndex = 0;   //웨이포인트 배열의 인덱스
        private Transform target;   //웨이포인트 오브젝트의 트랜스폼 객체

        #endregion

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {

            target = WayPoints.wayPoints[wayPointIndex];
            //초기화
            

        }

        // Update is called once per frame
        void Update()
        {
            //이동 구현
            Vector3 dir = target.position - this.transform.position;
            transform.Translate(dir.normalized * Time.deltaTime * speed,Space.World);

            //targetPosition 도착 판정
            float distance = Vector3.Distance(target.position, this.transform.position);
            if (distance <= 0.2f)
            {
                GetNextTargetPosition();
            }


        }
        //다음 타겟포지션 얻어오기
        void GetNextTargetPosition()
        {

            
            //Debug.Log($"웨이포인트 {wayPointIndex + 1} 도착" );
            //다음 타겟 셋팅
            wayPointIndex++; // 다음 웨이포인트로 이동

            // 웨이포인트가 남아있다면 이동
            if (wayPointIndex < WayPoints.wayPoints.Length)
            {
                
                target = WayPoints.wayPoints[wayPointIndex];
            }
            else
            {
               //Debug.Log("목표 지점 도달 - 이동 종료");
                Destroy(gameObject);
            }

        }
    }
}