using System.Collections;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
namespace MyDefence
{

    //라운드 숫자 텍스트 카운팅 애니메이션 연출
    public class RoundsText : MonoBehaviour
    {
        #region
        [SerializeField] TextMeshProUGUI roundsText;
        #endregion

        private void OnEnable()
        {
            StartCoroutine(AnimateNumberText(PlayerStats.Rounds));
        }
        //매개변수로 받은 숫자를 UI텍스트에서 애니메이션 연출
        IEnumerator AnimateNumberText(int targetNumber)
        {
            int aniNumber = 0;
            roundsText.text = aniNumber.ToString();
            yield return new WaitForSeconds(0.1f);
            while(aniNumber < targetNumber)
            {
                aniNumber++;
                roundsText.text = aniNumber.ToString();
                yield return new WaitForSeconds(0.1f);
            }

            //애니메이션 종료
        }
    }
}