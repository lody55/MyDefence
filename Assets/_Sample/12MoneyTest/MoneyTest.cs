using TMPro;
using UnityEngine;
using UnityEngine.UI;
namespace Sample
{
    //골드를 관리하는 클래스
    public class MoneyTest : MonoBehaviour
    {
        #region Field
        //소지금
        private int gold;
        public TextMeshProUGUI result;
        

        [SerializeField] int startGold;

        //Button UI
        public Button button2;
        public Button button3;
        #endregion

        private void Start()
        {
            //필드 초기화 - 초기금 설정(초기화)
            gold = startGold;
            Debug.Log($"소지금 {gold}골드를 지급 했습니다");

            
        }

        private void Update()
        {
            //소지금(gold)와 UI (골드텍스트) 연결
            result.text = gold.ToString() + "Gold";

            if(HasGold(1000))
            {
                //button2.image.color = Color.white;
                button2.interactable = true;
            }
            else
            {
                // button2.image.color = Color.red;
                button2.interactable = false;
            }
            if(HasGold(9000))
            {
                //button3.image.color = Color.white;
                button3.interactable = true;
            }
            else
            {
                //button3.image.color = Color.red;
                button3.interactable = false;
            }

            //아이템 구매가 가능하면 이미지 컬러 White, 소지금 부족하면 Red
            
        }
        //소지금 체크 : amount만큼 소지금을 가지고 있는지 여부
        public bool HasGold(int amount)
        {
            if(gold <amount )
            {
                return false;
            }
            return true;
        }


        //Gold를 연산하는 함수
        //돈을 번다 : 사냥,퀘스트 클리어, 캐쉬 구매, 이벤트 보상 등등....
        public void AddGold(int amount)
        {
            gold += amount;
        }
        //돈을 쓴다 : 아이템 구매 , 기구 사용 등등.....
        //돈이 부족하면 돈을 사용하지 않고 return false;
        //돈이 충분하면 돈을 사용하고 return true;
        public bool UseGold(int amount)
        {
            //소지금 체크
            if(gold < amount)
            {
                Debug.Log("소지금이 부족합니다");
                return false;
            }
            gold -= amount;
            return true;
        }

        //버튼 3개 클릭시 호출되는 함수 3개 만들고 각 버튼에 연결하세요
        //버튼 클릭시 골드 계산하고 출력하세요
        public void Button1()
        {
            AddGold(1000);
            Debug.Log("1000골드가 세이브 되었습니다");
        }
        public void Button2()
        {
            if(UseGold(1000)==true)
            {
                Debug.Log("1000골드로 구매 하였습니다");
            }
            
        }
        public void Button3()
        {
            if (UseGold(9000) == true)
            {
                Debug.Log("9000골드로 구매 하였습니다");
            }
            
        }

        
    }
}
/*
 MoneyTest

1. 시작하면 소지금을 1000원 지급
2. 화면상단에 소지금 표시(1000G)
3. 버튼 3개 만들기
1) 버튼1 = 저축 버튼(1000원 저축)버튼 클릭시 소지금 +1000 디버그로 "1000 Gold Save" 출력
2) 구매 버튼 = 1000G 아이템 구매, 버튼 클릭시 소지금 -1000 , 디버그로 "1000 Gold Item 구매" 출력
3) 구매 버튼 = 9000G 아이템 구매 ,버튼 클릭시 소지금 -9000 , 디버그로 "9000 Gold Item 구매" 출력
 
구매 버튼 : 아이템 구매가 가능하면 버튼 이미지는 White,
            소지금이 부족하여 구매가 불가능하면 이미지는 Red
            구매가 불가능하면 구매버튼을 클릭해도 구매가 불가능해야 한다
 
 */