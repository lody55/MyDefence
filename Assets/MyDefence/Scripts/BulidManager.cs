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

        #region Filed
        //타일에 설치할 타워 프리펩 오브젝트
        private GameObject towerToBulid;
        //타워 프리펩
        public GameObject machineGunPrefab;
        public GameObject rocketTowerPrefab;
        #endregion

        //타일에 설치할 타워 프리펩 오브젝트 얻어오기
        public GameObject GetTowerToBuild()
        {
            return towerToBulid;
        }

        private void Start()
        {
            
            
          // towerToBulid = machineGunPrefab;
        }
        //타일에 설치할 타워 프리펩 오브젝트 저장하기
        public void SetTowerToBuild(GameObject tower)
        {
            towerToBulid = tower;
        }
    }
}