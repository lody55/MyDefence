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

        //Life
        private static int life;


        //Button UI
        public Button muchineGunButton;
        public Button rocketButton;
        public Button LaserButton;
        #endregion

        #region Property
        //소지금 읽기 전용속성
        public static int Money
        {
            get { return money; }
        }

        public static int Life
        {
            get { return life; }
        }
        #endregion

        public void Start()
        {
            //초기화
            money = 400;
            Debug.Log("초기소지금 400원 지급!");
            life = 10;
            Debug.Log("초기 라이프 : 10");
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
            if (HasGold(250))
            {
                //button3.image.color = Color.white;
                LaserButton.interactable = true;
            }
            else
            {
                //button3.image.color = Color.red;
                LaserButton.interactable = false;
            }
        }
        public static void AddMoney(int amount)
        {
            money += amount;
        }
        public static bool UseMoney(int amount)
        {
            if (money < amount)
            {
                Debug.Log("소지금이 부족합니다");
                return false;
            }
            money -= amount;
            return true;
        }

        public static bool HasGold(int amount)
        {
            if (money < amount)
            {
                return false;
            }
            return true;
        }

        //생명 사용
        public static void UseLife(int mylife)
        {
            life -= mylife;
            if(life <= 0)
            {
                life = 0;
                Debug.Log("당신은 패배 했습니다");
                
            }
        }
        //생명 추가
        public static void AddLife(int mylife)
        {
            life += mylife;
        }











        //public void MyMoney(int amount)
        //{
        //    money = amount;
        //    Debug.Log($"현재 소지금 : {amount}");
        //}
        //public void MuchinGunButton()
        //{
        //    if (UseMoney(100) == true)
        //    {
        //        Debug.Log("머신건 타워 구입");
        //    }
        //}
        //public void RocketTowerButton()
        //{
        //    if(UseMoney(150) == true)
        //    {
        //        Debug.Log("로켓 타워 구입");
        //    }
        //}


        //초기 소지금 400
        //벌기 , 쓰기, 소지금 확인 함수 만들기


    }
}