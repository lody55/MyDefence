using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
namespace MyDefence
{
    public class MainMenu : MonoBehaviour
    {

        public Button playButton;
        public Button quitButton;
        [SerializeField] int SceneNumber = 0;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //playButton.onClick.AddListener(PlayButtonClick);
            //quitButton.onClick.AddListener(QuitButtonClick);
        }

        // Update is called once per frame
        void Update()
        {

        }

        //플레이 버튼 클릭하면 호출되는 함수
        public void PlayButtonClick()
        {
            SceneManager.LoadScene(SceneNumber);
        }

        //종료 버튼 클릭하면 호출되는 함수
        public void QuitButtonClick()
        {
            Debug.Log("게임 종료");
            Application.Quit();     //유니티 에디터에서 명령 무시, 빌드버전에서는 구동
        }
    }
}