using UnityEngine;
using TMPro;
namespace MyDefence
{
    public class DrawMoney : MonoBehaviour
    {
        //플레이 화면의 Money UI 그리기

        public TextMeshProUGUI moneyText;
        
        void Update()
        {
            moneyText.text = PlayerStats.Money.ToString();
        }
    }
}