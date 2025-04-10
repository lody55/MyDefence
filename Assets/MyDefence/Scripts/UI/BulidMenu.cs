using UnityEngine;
namespace MyDefence
{
    public class BulidMenu : MonoBehaviour
    {
        #region Field
        //타워(건설)정보를 가지고 있는 객체
        public TowerBluePrint machineGunTower;
        public TowerBluePrint rocketTower;
        #endregion
        //MachineGunButton 클릭시 호출되는 함수
        public void MachinGunButton()
        {
            //빌드매니저의 towerToBuild에 machineGun을 저장
            BulidManager.Instance.SetTowerToBuild(machineGunTower);
            Debug.Log("towerToBuild에 machineGun을 저장");
        }
        
        //RocketTowerButton 클릭시 호출되는 함수
        public void RocketTowerButton()
        {
            Debug.Log("towerToBulid에 RocketTower을 저장한다");
            BulidManager.Instance.SetTowerToBuild(rocketTower);

        }
    }
}