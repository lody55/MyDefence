using UnityEngine;
namespace MyDefence
{
    //맵의 타일을 관리하는 클래스
    public class Tile : MonoBehaviour
    {
        #region Field
        //마우스를 올려놓으면 변하는 색
        //public Color hoverColor;
        //타일의 원래 색깔
        //private Color startColor;
        //타일을 그리는 Renderer
        private Renderer renderer;

        //마우스를 올려놓으면 변하는 메터리얼
        public Material hoverMaterial;
        //타일의 원래 메터리얼
        private Material starMaterial;


        #endregion

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //참조 
            renderer = this.transform.GetComponent<Renderer>();

            //초기화
            starMaterial = renderer.material;
        }

        
        private void OnMouseEnter()
        {
            Debug.Log("터렛을 설치합니다");
            //renderer.material.color = hoverColor;
            renderer.material = hoverMaterial;
        }
        
        private void OnMouseDown()
        {
            Debug.Log("이 스크립트가 붙어있는 타일위에 터렛 설치");
            Instantiate(BulidManager.Instance.GetTowerToBuild(), this.transform.position, Quaternion.identity);
        }

        private void OnMouseOver()
        {
            
        }
        private void OnMouseExit()
        {
            Debug.Log("OnMouseExit");
            // renderer.material.color = startColor;
            renderer.material = starMaterial;
        }
    }
}