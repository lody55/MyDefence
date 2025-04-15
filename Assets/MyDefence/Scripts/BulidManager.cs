using Unity.VisualScripting;
using UnityEngine;
namespace MyDefence
{
    //타워 건설을 관리하는 싱글톤 클래스
    public class BulidManager : MonoBehaviour
    {
        #region Singleton

        private static BulidManager instance;

        public static BulidManager Instance
        {
            get
            {
                return instance;
            }

        }
        private void Awake()
        {
            if(instance != null)
            {
                Destroy(gameObject);
                return;
            }
            instance = this;
            //DontDestroyOnLoad(gameObject);
        }
        #endregion

        #region Field
        //타일에 설치할 타워 정보를 저장하는 변수 
        private TowerBluePrint towerToBulid;

        //타일에 설치할 타워의 건설 비용
        private int buildCost;

        public TileUI tileUI;

        private Tile selectedTile;
        //타워 프리펩
        //public GameObject machineGunPrefab;
        //public GameObject rocketTowerPrefab;
        #endregion
        #region Property
        //타워 건설 비용을 체크하는 프로퍼티 = 부족하면 true 
        public bool NotEnoughMoney
        {
            get { return PlayerStats.Money < towerToBulid.cost; }
        }

        //건설할 타워가 있는지 체크, 건설할 타워를 선택하지 않았을때
        public bool CannotBuild
        {
            get { return towerToBulid == null; }
        }
        #endregion

        //타일에 설치할 타워 프리펩 오브젝트 얻어오기
        public TowerBluePrint GetTowerToBuild()
        {
            return towerToBulid;
        }

        private void Start()
        {
            
            
          // towerToBulid = machineGunPrefab;
        }
        //타일에 설치할 타워 프리펩 오브젝트 저장하기
        public void SetTowerToBuild(TowerBluePrint tower)
        {
            towerToBulid = tower;

            if (tower == null)
            {
                buildCost = 0;
                return;
            }

            buildCost = tower.cost; //null아닐 때 실행
        }
        //public int GetBuildCost()
        //{
        //    return buildCost;
        //}

        //타워가 설치된 타일을 선택
        public void SelectTile(Tile tile)
        {
            // 이미 선택된 타일을 다시 클릭하면 UI 닫기
            if (selectedTile == tile)
            {
                DeSelectTile(); // UI 숨기고 선택 해제
                return;
            }

            selectedTile = tile; // 새로운 타일 선택
            tileUI.ShowTileUI(tile);
        }

        public void DeSelectTile()
        {
            tileUI.HideTileUI();
            selectedTile = null;
        }
    }
}