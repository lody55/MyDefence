using UnityEngine;
using TMPro;
using UnityEngine.UI;
namespace MyDefence
{
    public class TileUI : MonoBehaviour
    {
        #region Field
        public GameObject offSet;
        private Tile selectedTile;

        
        //업그레이드 cost Text UI
        public TextMeshProUGUI upgradeCost;
        public Button upgradeButton;
        #endregion


        //타일 UI 보이기
        public void ShowTileUI(Tile tile)
        {
            selectedTile = tile; // 선택된 타일 저장
            transform.position = tile.transform.position + new Vector3(0, 1f, 0);

            if(tile.IsUpgrade)
            {
                upgradeCost.text = "COMPLETE";
                upgradeButton.interactable = false;
            }
            else
            {
                //업그레이드 가격 표시
                upgradeCost.text = tile.bluePrint.upgradeCost.ToString() + "G";
                upgradeButton.interactable = true;
            }

            

            offSet.SetActive(true);
        }

        //타일 UI 감추기
        public void HideTileUI()
        {
            selectedTile = null;
            offSet.SetActive(false);
        }

        public void UpgradeTower()
        {
            if (selectedTile != null)
            {
                selectedTile.UpgradeTower();
            }
            //창 닫기 = 선택한 타일을 해제하기
            BulidManager.Instance.DeSelectTile();

        }


    }
}