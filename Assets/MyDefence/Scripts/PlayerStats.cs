using TMPro;
using UnityEngine;
using UnityEngine.UI;
namespace MyDefence
{
    //플레이어의 속성들을 관리하는 클래스
    public class PlayerStats : MonoBehaviour
    {
        #region Filed
        //소지금
        private static int money;

        
        public TextMeshProUGUI result;


        

        //Button UI
        public Button muchineGunButton;
        public Button rocketButton;
        #endregion

        #region Property
        //소지금 읽기 전용속성
        public static int Money
        {
            get { return money; }
        }
        #endregion

        public void Start()
        {
            money = 400;
            Debug.Log("소지금 400원 지급!");
        }
        public void Update()
        {
            if (HasGold(100))
            {
                //button2.image.color = Color.white;
                muchineGunButton.interactable = true;
            }
            else
            {
                // button2.image.color = Color.red;
                muchineGunButton.interactable = false;
            }
            if (HasGold(150))
            {
                //button3.image.color = Color.white;
                rocketButton.interactable = true;
            }
            else
            {
                //button3.image.color = Color.red;
                rocketButton.interactable = false;
            }
        }
        public void AddMoney(int amount)
        {
            money += amount;
        }
        public bool UseMoney(int amount)
        {
            if(money < amount)
            {
                Debug.Log("소지금이 부족합니다");
                return false;
            }
            money -= amount;
            return true;
        }

        public bool HasGold(int amount)
        {
            if (money < amount)
            {
                return false;
            }
            return true;
        }

        public void MyMoney(int amount)
        {
            money = amount;
            Debug.Log($"현재 소지금 : {amount}");
        }
        public void MuchinGunButton()
        {
            if (UseMoney(100) == true)
            {
                Debug.Log("머신건 타워 구입");
            }
        }
        public void RocketTowerButton()
        {
            if(UseMoney(150) == true)
            {
                Debug.Log("로켓 타워 구입");
            }
        }


        //초기 소지금 400
        //벌기 , 쓰기, 소지금 확인 함수 만들기


    }
}