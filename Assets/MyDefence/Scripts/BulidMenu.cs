using UnityEngine;
namespace MyDefence
{
    public class BulidMenu : MonoBehaviour
    {
        //MachineGunButton 클릭시 호출되는 함수
        public void MachinGunButton()
        {
            //빌드매니저의 towerToBuild에 machineGunPrefab을 저장
            BulidManager.Instance.SetTowerToBuild(BulidManager.Instance.machineGunPrefab);
            Debug.Log("towerToBuild에 machineGunPrefab을 저장");
        }
    }
}