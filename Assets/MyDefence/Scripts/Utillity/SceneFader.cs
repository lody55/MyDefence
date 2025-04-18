using UnityEngine;
using UnityEngine.UI;
namespace MyDefence
{
    
    public class SceneFader : MonoBehaviour
    {
        #region Field
        //페이더 이미지
        public Image img;
        #endregion
        //코루틴으로 구현
        private void Start()
        {
            //FadeIn효과 = 1초동안 : 페이드인(이미지 알파값 a:1 >>> a:0) 검정에서 투명
            

        }



        //FadeOut = 1초동안 : 페이드아웃 (이미지 알파값 a:0 >>> a:1) 투명에서 검정

    }
}