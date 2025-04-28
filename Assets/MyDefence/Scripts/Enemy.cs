using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;
namespace MyDefence
{
    //적의 전투(체력, 데미지 관리)하는 클래스
    public class Enemy : MonoBehaviour , IDamageable
    {
        //필드
        #region Field
        [SerializeField] Image EnemyUI;
        private EnemyMove enemyMove;

        private float hp;    //적 체력
        private bool isDeath = false;   //죽음 체크
        

        [SerializeField] private float startHp = 100f; // 체력초기화
        [SerializeField]private int rewardGold = 50; //리워드 골드
        public GameObject deathEffectPrefab; //죽음 이펙트 프리펩

        #endregion

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            hp = startHp;
            enemyMove = this.GetComponent<EnemyMove>();
        }

        // Update is called once per frame
        void Update()
        {
            
            

        }
        //다음 타겟포지션 얻어오기
        
        //데미지 처리
        public void TakeDamage(float damage)
        {
            if (enemyMove.IsArrive) return;
            //연산
            hp -= damage;
            //Debug.Log($"현재 체력 : {hp}");

            EnemyUI.fillAmount = hp / startHp;

            //데미지 효과


            //죽음 체크 , 두번 죽는것 체크
            if(hp <= 0 && isDeath == false)
            {
                Die();
            }
        }
        private void Die()
        {
            if (isDeath) return;

            isDeath = true;
            //보상, 벌
            //리워드 50Gold 지급
            PlayerStats.AddMoney(rewardGold);

            //VFX , SFX
            //죽는 파티클 이펙트 만들어서 처리
            GameObject effectGo = Instantiate(deathEffectPrefab,this.transform.position,Quaternion.identity);

            //Enemy 카운팅
            Wavemanager.enemyAlive--;
            Debug.Log($"enemyAlive : {Wavemanager.enemyAlive}");

            //킬
            
            Destroy(this.gameObject,0f);
            Destroy(effectGo, 2f);
        }

        //매개변수로 입력받은 감속률 만큼 속도 감속
        public void Slow(float rate)
        {
            enemyMove.moveSpeed = enemyMove.StartMoveSpeed * (1-rate);
        }

    }
}
