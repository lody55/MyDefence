using UnityEngine;
namespace MyDefence
{
    //레이져 타워를 관리하는 클래스
    public class LaserTower : Tower
    {
        #region Field
        public LineRenderer lineRenderer;   //레이저빔 그리기
        public ParticleSystem impactEffect; //레이저 임팩트 효과
        public Light ImpactLight;
        private float laserDamage = 30;

        //속도 40% 감속
        [SerializeField] private float slowRate = 0.4f;
        #endregion

        protected override void Update()
        {
            
            //타겟 없으면
            if (target == null)
            {
                if (lineRenderer.enabled)
                {
                    lineRenderer.enabled = false;
                    impactEffect.Stop();
                    ImpactLight.enabled = false;
                }
                return;
            }
            //타겟 조준
            Lockon();

            //레이저 빔 그리기
            Laser();

        }
        void Laser()
        {
            //레이져 효과 연산하기
            //dir * Time.deltaTime * movespeed // 1초에 30가기 <<< (이거랑 연산 비슷하다)
            //이번 프레임에 주는 데미지량
            float damage = laserDamage * Time.deltaTime;
            
            if (targetEnemy != null)
            {
                targetEnemy.TakeDamage(damage);
                targetEnemy.Slow(slowRate);
            }

            if (lineRenderer.enabled == false)
            {
                lineRenderer.enabled = true;
                impactEffect.Play();
                ImpactLight.enabled = true;
            }
            
            lineRenderer.SetPosition(0,firePoint.position);
            lineRenderer.SetPosition(1, target.position);

            impactEffect.transform.position = target.position;
            
            //타겟에서 FirePoint를 바라보는 방향 구하기
            Vector3 dir = target.position - firePoint.position;
            Vector3 impact = target.position - dir.normalized * 0.5f;
            impactEffect.transform.position = impact;
            //파티클 방향 조정
            impactEffect.transform.rotation = Quaternion.LookRotation(-dir);
        }
    }
}