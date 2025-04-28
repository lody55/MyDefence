using UnityEngine;
namespace MyDefence
{
    //적의 이동을 관리하는 클래스
    public class EnemyMove : MonoBehaviour
    {

        //필드
        #region Field

        //이동속도
        [HideInInspector]public float moveSpeed ;

        [SerializeField] private float startMoveSpeed; //이동속도 - origin
        private Vector3 targetPosition;
        private int wayPointIndex = 0;   //웨이포인트 배열의 인덱스
        private Transform target;   //웨이포인트 오브젝트의 트랜스폼 객체
        //private bool isArrive = false;

        private bool isArrive = false;

        public bool IsArrive
        {
            get { return isArrive; }
        }

        
        public float StartMoveSpeed { get { return startMoveSpeed; } }
        #endregion

        private void Start()
        {
            startMoveSpeed = moveSpeed;
            target = WayPoints.wayPoints[wayPointIndex];
        }
        private void Update()
        {
            //이동 구현
            Vector3 dir = target.position - this.transform.position;
            transform.Translate(dir.normalized * Time.deltaTime * moveSpeed, Space.World);

            //targetPosition 도착 판정
            float distance = Vector3.Distance(target.position, this.transform.position);
            if (distance <= 0.2f)
            {
                GetNextTargetPosition();
            }

            //속도 원복
            moveSpeed = startMoveSpeed;

        }
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
                Wavemanager.enemyAlive--;
                PlayerStats.UseLife(1);
                //Debug.Log("목표 지점 도달 - 이동 종료");

                Debug.Log($"enemyAlive : {Wavemanager.enemyAlive}");
                Destroy(gameObject);
            }
        }
    }
}