using UnityEngine;
using UnityEngine.EventSystems;
namespace MyDefence
{
    //맵의 타일을 관리하는 클래스
    public class Tile : MonoBehaviour
    {
        #region Field
        //마우스를 올려놓으면 변하는 색
        //public Color hoverColor;
        //타일의 원래 색깔
        //private Color startColor;
        //타일을 그리는 Renderer
        //private Renderer renderer;!!!!!!!!!!!!!!!!!!!

        //마우스를 올려놓으면 변하는 메터리얼
        public Material hoverMaterial;

        //돈이 부족할때 마우스를 올려놓으면 변하는 메터리얼
        public Material MoneyMaterial;

        //타일의 원래 메터리얼
        private Material starMaterial;

        private BulidManager bulid;

        //타일에 설치한 타워 오브젝트
        private GameObject tower;

        //타일에 설치한 타워의 정보 - 안에 프리펩, 가격정보가 있다
        public TowerBluePrint bluePrint;

        //타워 건설 이펙트 프리펩
        public GameObject buildEffectPrefab;

        #endregion
        #region Property
        public bool IsUpgrade { get; private set; }
        #endregion

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            bulid = BulidManager.Instance;
            //참조 
           // renderer = this.transform.GetComponent<Renderer>();!!!!!!!!!!!!!!!!!!!!!!!!!!

            //초기화
            starMaterial = GetComponent<Renderer>().material;
            IsUpgrade = false;
        }

        
        private void OnMouseEnter()
        {
            if (EventSystem.current.IsPointerOverGameObject() == true)
            {

                return;
            }
            if (bulid.CannotBuild )
            {
                return;
            }

            BuildTower();

            
        }

        private void OnMouseDown()
        {
            if (EventSystem.current.IsPointerOverGameObject())
            {
                return;
            }
            //Debug.Log($"현재 타워 상태: {(tower == null ? "없음" : "설치됨")}");
            if (tower != null)
            {
                Debug.Log("타워 설치되어 있음 - 타일 선택");
                bulid.SelectTile(this); // UI 띄우기
                return; 
            }

                

            if (bulid.CannotBuild) return;

            if (tower != null)
            {
                BulidManager.Instance.tileUI.ShowTileUI(this);
                return;
            }

            bluePrint = bulid.GetTowerToBuild();

            if (!PlayerStats.UseMoney(bluePrint.cost))
            {
                Debug.Log("소지금 부족!");
                return;
            }


            // 타워 설치
            tower = Instantiate(bluePrint.towerPrefab, transform.position, Quaternion.identity);

            // 설치 이펙트
            if (buildEffectPrefab != null)
            {
                GameObject effect = Instantiate(buildEffectPrefab, transform.position, Quaternion.identity);
                Destroy(effect, 2f);
            }
            bulid.SetTowerToBuild(null);
            Debug.Log($"타워 건설 완료! 남은 소지금 {PlayerStats.Money}");
            
        }

       
        private void OnMouseExit()
        {
            //Debug.Log("OnMouseExit");
            // renderer.material.color = startColor;
            GetComponent<Renderer>().material = starMaterial;
        }
        public void BuildTower()
        {
            //건설비용 체크
            if (bulid.NotEnoughMoney)
                return;

            //건설된 타워의 정보를 저장
            bluePrint = bulid.GetTowerToBuild();
            //renderer.material.color = hoverColor;
            if (bulid.NotEnoughMoney)
            {
                GetComponent<Renderer>().material = MoneyMaterial;
            }
            else
            {
                GetComponent<Renderer>().material = hoverMaterial;
            }


        }

        public void UpgradeTower()
        {
            //건설비용 체크
            if (IsUpgrade)
            {
                Debug.Log("이미 업그레이드 완료된 타워입니다!");
                return;
            }
            if (!PlayerStats.UseMoney(bluePrint.upgradeCost))
            {
                Debug.Log("소지금 부족으로 업그레이드 실패!");
                return;
            }
            // 기존 타워 제거
            Destroy(tower);

            IsUpgrade = true;

            //업그레이드 프리펩 설치
            
            tower = Instantiate(bluePrint.upgradePrefab, transform.position, Quaternion.identity);
            //이펙트 - 건설 이펙트와 같은것 사용
            {
                if (buildEffectPrefab != null)
                {
                    GameObject effect = Instantiate(buildEffectPrefab, transform.position, Quaternion.identity);
                    Destroy(effect, 2f);
                }
            }


            
        }
    }
}