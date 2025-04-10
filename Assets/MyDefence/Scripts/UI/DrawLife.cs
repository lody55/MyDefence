using UnityEngine;
using TMPro;
namespace MyDefence
{
    public class DrawLife : MonoBehaviour
    {
        //플레이 화면의 Money UI 그리기

        public TextMeshProUGUI LifeText;

        void Update()
        {
            LifeText.text = PlayerStats.Life .ToString();
        }
    }
}