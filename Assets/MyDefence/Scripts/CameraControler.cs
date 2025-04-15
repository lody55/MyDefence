using UnityEngine;
namespace MyDefence
{
    public class CameraControler : MonoBehaviour
    {
        //카메라 제어하는 클래스
        #region Field
        //카메라 이동속도
        public float moveSpeed = 10f;

        //카메라 스크롤 스피드
        public float scrollSpeed = 10f;
        public float scrollMin = 10f;
        public float scrollMax = 40f;

        //카메라 컨트롤 제어 유무(true 이면 못 움직인다 , false : 움직인다)
        public bool isCannnotMove = false;
        #endregion
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //필드 초기화
            isCannnotMove = false;
        }

        // Update is called once per frame
        void Update()
        {
            //게임 오버 체크
            if (GameManager.IsGameOver)
                return;

            //isCannnotMove가 true면 return 아래 코드를 실행하지 말라
            
                
            //esc키 누르면 이동 불가 isCannotMove = true (!isCannotMove)
            //esc키 한번더 누르면 이동가능 isCannotMove = false (!isCannotMove)
            //if (Input.GetKeyDown(KeyCode.Escape))
            //{
            //    isCannnotMove = !isCannnotMove; //토글 기능
                    
            //}
            if (isCannnotMove)
                return;
            //W,S,A,D키 (또는 키보드의 상하좌우 화살표)값을 받아
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            {
                this.transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed,Space.World);
            }
            if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            {
                this.transform.Translate(Vector3.back* Time.deltaTime * moveSpeed, Space.World);
            }
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                this.transform.Translate(Vector3.left* Time.deltaTime * moveSpeed, Space.World);
            }
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                this.transform.Translate(Vector3.right* Time.deltaTime * moveSpeed, Space.World);
            }
            //마우스 포인터가 스크린 상단에 위치하면 앞으로 스크롤
            float mouseX = Input.mousePosition.x ;
            float mouseY = Input.mousePosition.y;
            if (mouseY >= (Screen.height - 10)&& mouseY < Screen.height)
            {
                this.transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed,Space.World);
            
            }
            //마우스 포인터가 스크린 하단에 위치하면 뒤로 스크롤
            if (mouseY <= 10 && mouseY >0)
            {
                this.transform.Translate(Vector3.back* Time.deltaTime * moveSpeed, Space.World);

            }
            //마우스 포인터가 스크린 좌측 끝에 위치하면 좌측으로 스크롤
            if (mouseX <= 10 && mouseX > 0)
            {
                this.transform.Translate(Vector3.left * Time.deltaTime * moveSpeed, Space.World);

            }
            //마우스 포인터가 스크린 우측 끝이 위치하면 우측으로 스크롤
            if (mouseX >= Screen.width -10 && mouseX > Screen.width)
            {
                this.transform.Translate(Vector3.right * Time.deltaTime * moveSpeed, Space.World);

            }

            //마우스 휠을 스크롤하면 화면의 줌인 줌아웃 한다
            //float scroll = Input.GetAxis("Mouse ScrollWheel");
            //Debug.Log($"ScrollWheel : {scroll}");

            //Vector3 upMove = this.transform.position;
            //upMove.y += (scroll * 1000) * Time.deltaTime * scrollSpeed;
            ////(upMove.y : 10f 이상 , 40f 이하)
            //upMove.y = Mathf.Clamp(upMove.y, scrollMin, scrollMax);
            //this.transform.position = upMove;
        }

    }
}