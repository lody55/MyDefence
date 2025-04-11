using UnityEngine;
namespace MyDefence
{
    public class GameManager : MonoBehaviour
    {
        #region Field
        private bool isCheat = false;
        #endregion

        private void Update()
        {
            //Cheating
            //M키를 누르면 10만골드 지급
            if(Input.GetKeyDown(KeyCode.M))
            {
                ShowMeTheMoney();
            }
        }

        void ShowMeTheMoney()
        {
            if (isCheat == false)
                return;
            PlayerStats.AddMoney(1000000);
        }

        //레벨업 치팅
        void LevelUpCheat()
        {
            //PlayerStats.Levelup();
        }
        
    }
}