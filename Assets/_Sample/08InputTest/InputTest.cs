using TMPro;
using UnityEngine;
namespace Sample
{
    public class InputTest : MonoBehaviour
    {
        //UI Text 가져오기
        public TextMeshProUGUI xText;
        public TextMeshProUGUI yText;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Debug.Log($"Screen Width : {Screen.width}");
            Debug.Log($"Screen Height : {Screen.height}");
        }

        // Update is called once per frame
        void Update()
        {
            //키 입력 - GetKey(키 값)
            //if (Input.GetKey("w"))
            //{
            //    Debug.Log("w키 누르고 있습니다");
            //}
            //if(Input.GetKeyDown(KeyCode.W))
            //{
            //    Debug.Log("w키 눌렀습니다 ") ;
            //}
            //if(Input.GetKeyUp(KeyCode.W))
            //{
            //    Debug.Log("w키를 눌렀다가 떼었습니다");
            //}

            ////GetBotton 입력(버튼이름) - InputManager
            //if(Input.GetButton("Jump"))
            //{
            //    Debug.Log("점프 버튼을 누르고 있습니다");
            //}
            //if (Input.GetButtonDown("Jump"))
            //{
            //    Debug.Log("점프 버튼을 눌렀습니다");
            //}
            //if (Input.GetButtonUp("Jump"))
            //{
            //    Debug.Log("점프 버튼을 눌렀다 떼었습니다");
            //}

            //GetAxis

            //왼쪽 , 오른쪽
            //float hValue = Input.GetAxis("Horizontal");
            //Debug.Log($"Horizontal 값 : {hValue}");
            //a, left : -1 ~0 
            //d, right : 1 ~0
            //float hValues = Input.GetAxisRaw("Horizontal");
            //Debug.Log($"Horizontal 값 : {hValues}");
            //a, left : 한번에 -1 ~0  
            //d, right : 한번에 1 ~0


            // 위, 아래
            float vValue = Input.GetAxis("Vertical");
            Debug.Log($"Vertical 값 : {vValue}");

            //마우스 포인터의 스크린 위치값 얻어오기
            float mouseX = Input.mousePosition.x;
            float mouseY = Input.mousePosition.y;

            //xText.text = "MouseX :" +((int)mouseX).ToString();
            //yText.text = "MouseY :" + ((int)mouseY).ToString();
            xText.text = "MouseX :" + ((int)mouseX).ToString() + ","+ ((int)mouseY).ToString();
            xText.rectTransform.position = new Vector2(mouseX, mouseY);
        }
    }
}

/*
Old InputSystem

New InputSystem
 */