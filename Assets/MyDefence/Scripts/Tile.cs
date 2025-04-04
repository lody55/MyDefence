using UnityEngine;
using UnityEngine.EventSystems;
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
        //private Renderer renderer;!!!!!!!!!!!!!!!!!!!

        //마우스를 올려놓으면 변하는 메터리얼
        public Material hoverMaterial;
        //타일의 원래 메터리얼
        private Material starMaterial;

        private BulidManager bulid;

        //타일에 설치한 타워 오브젝트
        private GameObject tower;
        #endregion

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            bulid = BulidManager.Instance;
            //참조 
           // renderer = this.transform.GetComponent<Renderer>();!!!!!!!!!!!!!!!!!!!!!!!!!!

            //초기화
            starMaterial = GetComponent<Renderer>().material;
        }

        
        private void OnMouseEnter()
        {
            if (EventSystem.current.IsPointerOverGameObject() == true)
            {
                return;
            }
            if (bulid.GetTowerToBuild()== null)
            {
                return;
            }
            //renderer.material.color = hoverColor;
            GetComponent<Renderer>().material = hoverMaterial;
        }
        
        private void OnMouseDown()
        {
            if(EventSystem.current.IsPointerOverGameObject() == true)
            {
                return;
            }
            if(bulid.GetTowerToBuild() == null)
            {
                Debug.Log("설치할 타워가 없습니다!");
                return;
            }

            //현재 타일에 타워가 설치되었는지 체크
            if(tower != null)
            {
                Debug.Log("타워를 설치할 수 없습니다!");
                return;
            }

            //Debug.Log("이 스크립트가 붙어있는 타일위에 터렛 설치");
            tower = Instantiate(bulid.GetTowerToBuild(), this.transform.position, Quaternion.identity);

            //초기화 - 저장된 타워 프리펩 초기화
            bulid.SetTowerToBuild(null);
        }

        private void OnMouseOver()
        {
            
        }
        private void OnMouseExit()
        {
            Debug.Log("OnMouseExit");
            // renderer.material.color = startColor;
            GetComponent<Renderer>().material = starMaterial;
        }
    }
}