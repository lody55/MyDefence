using UnityEngine;

namespace MyDefence
{
    //로켓을 관리하는 클래스
    public class Rocket : Bullet
    {
        #region Field
        //데미지 영역
        public float damageRange = 3.5f;
        //emnemy 오브젝트 태그 스트링
        public string enemyTag = "Enemy";
        #endregion

        //기즈모 데미지 영역 그리기

        private void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(this.transform.position, damageRange);
        }

        //타겟을 맞춰 폭발하여 데미지 영역에 있는 적 킬
        protected override void Hittarget()
        {
            //타격 이펙트 효과 적용
            GameObject effectGo = Instantiate(bulletImpactPrefab, this.transform.position, Quaternion.identity);
            Destroy(effectGo, 2f);


            //타겟 게임오브젝트 폭발
            Explosion();

            //탄환 게임오브젝트 킬
            Destroy(this.gameObject);
        }

        //폭발 - 데미지 영역(3.5f)에 있는 적을 찾아 킬
        private void Explosion()
        {
            Collider[] hitColliders = Physics.OverlapSphere(this.transform.position, damageRange);
            //폭발 - 데미지 영역(3.5f) Enemy 킬
            foreach(var hitCollider in hitColliders)
            {
                //데미지 영역안의 모든 충돌체에서 Enemy 찾기
                if(hitCollider.tag == enemyTag)
                {
                    Destroy(hitCollider.gameObject);
                }
            }
        }

    }
    
}