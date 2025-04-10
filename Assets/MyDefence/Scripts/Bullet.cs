using UnityEngine;
namespace MyDefence
{
    //탄환(발사체)를 관리하는 클래스 - 모든 발사체의 부모 클래스
    public class Bullet : MonoBehaviour
    {
        #region Field
        //타겟 오브젝트
        private Transform target;
        //이동 속도
        public float moveSpeed = 30f;

        //타격 이펙트 프리펩
        public GameObject bulletImpactPrefab;

        protected float atkDamage = 50f;

        #endregion

        public void SetTarget(Transform _target)
        {
            this.target = _target;
            if (_target == null)
            {
                Debug.LogError("타겟이 설정되지 않았습니다!");
            }
        }
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if(target ==null)
            {
                Destroy(this.gameObject);
                return;
            }
            //이동하기
            //dir.magnitude : 두 벡터간의 거리
            Vector3 dir = target.position - this.transform.position; 
            float distanceThisFrame = Time.deltaTime * moveSpeed;   //이번 프레임에 이동하는 거리
            if(dir.magnitude <= distanceThisFrame)
            {
                Hittarget(); 
                return;
            }

            transform.position = Vector3.MoveTowards(transform.position, target.position, distanceThisFrame);
        }
        //타겟을 맞춰 적을 킬(뷸렛)
        protected virtual void Hittarget()
        {
            // 타겟이 없으면 실행하지 않기
            if (target == null) return;

            // 타격 이펙트 효과 적용
            GameObject effectGo = Instantiate(bulletImpactPrefab, this.transform.position, Quaternion.identity);
            Destroy(effectGo, 2f);

            //Debug.Log("HitTarget!!");

            // 타겟 게임오브젝트 데미지 주기
            AtkTarget(target);
            

            // 탄환 게임오브젝트 킬
            Destroy(this.gameObject);


        }
        //매개변수로 들어온 타겟이게 데미지 주기
        protected void AtkTarget(Transform _target)
        {
            //AtkDamage만큼 타겟의 hp 감산
            Enemy enemy = _target.GetComponent<Enemy>();
            if (enemy != null)
            {
                enemy.TakeDamage(atkDamage);
            }
            //Debug.Log("target에게 데미지 주기");
            
        }
    }
}