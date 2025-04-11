using UnityEngine;
namespace MyDefence
{
    public class Tower : MonoBehaviour
    {
        //타워 부모 클래스
        #region Field
        //공격 범위
        public float attackRange = 7f;
        //가장 가까운 적
        protected Transform target;
        protected Enemy targetEnemy;

        //Enemy tag
        public string enemyTag = "Enemy";
        private float Interval = 0.1f;

        public Transform partToRotate;
        public float turnSpeed = 5f;


        //shoot 타이머 - 1초에 한발씩 발사
        public float shootTimer = 1f;
        private float shootCountdown = 0;

        //Bullet 발사
        //뷸렛 프리펩
        public GameObject bulletPrefab;
        //발사 위치
        public Transform firePoint;
        #endregion
        void Start()
        {
            InvokeRepeating("UpdateTarget", 0f, Interval);
        }
        private void UpdateTarget()
        {
            GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag);

            //최소거리 일때의 적 구하기
            float minDistance = float.MaxValue;
            GameObject nearEnemy = null;
            foreach (var enemy in enemies)
            {
                float distance = Vector3.Distance(this.transform.position, enemy.transform.position);
                if (distance < minDistance)
                {
                    minDistance = distance;
                    nearEnemy = enemy;
                }
            }
            //Debug.Log($"minDistance : {minDistance}");
            if (nearEnemy != null && minDistance <= attackRange)
            {
                target = nearEnemy.transform;
                targetEnemy = target.GetComponent<Enemy>();
                //Debug.Log("Find target");
            }
            else
            {
                target = null;
                targetEnemy = null;
            }
        }


        protected virtual void Lockon()
        {
            //타겟이 없으면
            if (target == null) return;

            // 터렛 헤드 회전 (부드럽게 회전하기 위해 Lerp 사용)
            Vector3 dir = target.position - this.transform.position;

            // 수평으로만 회전하도록 Y축 값은 0으로 설정
            dir.y = 0f;

            Quaternion targetRotation = Quaternion.LookRotation(dir);
            Quaternion smoothRotation = Quaternion.Lerp(partToRotate.rotation, targetRotation, Time.deltaTime * turnSpeed);

            partToRotate.rotation = smoothRotation;
        }

        protected virtual void Update()
        {
            if (target == null) return; // 타겟이 없으면 발사하지 않음.

            //타겟 조준
            Lockon();

            //타겟팅이 되면 터렛이 1초마다 한발씩 쏘기
            //Debug.Log("Shoot!!!!!");
            shootCountdown += Time.deltaTime;
            if (shootCountdown >= shootTimer && target != null)
            {
                //타이머 기능 - 1발씩 쏘기
                Shoot();
                //타이머 초기화
                shootCountdown = 0f;
            }

        }

        //탄환 발사
        private void Shoot()
        {
            //Debug.Log("Shoot!!!!");
            //Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);
            GameObject bulletGO = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            Bullet bullet = bulletGO.GetComponent<Bullet>();
            if (bullet != null)
            {
                bullet.SetTarget(target);
            }

        }

        private void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(this.transform.position, attackRange);
        }
    }
}
    
