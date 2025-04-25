using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
namespace MyDefence
{
    public class GameOverUI : MonoBehaviour
    {
        #region Field
        public Button RETRYButton;
        public Button MENUButton;
        public Button CONTINUEButton;
        public TextMeshProUGUI roundText;

        //씬페이더
        public SceneFader fader;
        private string loadToScene = "MainMenu";



        public GameObject gameOverUI;
        #endregion

        //활성화시 한번만 호출하고 값을 초기화한다
        private void OnEnable()
        {
            roundText.text = PlayerStats.Rounds.ToString();
        }

        private void Start()
        {
            
        }
        private void Update()
        {
            
            
        }
        public void ReTryButton()
        {
            Debug.Log("Run Retry");

            //모든 초기화(해당 씬을 다시부른다)
            //SceneManager.LoadScene("UnityTest");  //씬이름으로 로드

            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            fader.FadeTo(SceneManager.GetActiveScene().name);
            Time.timeScale = 1f;
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        public void MenuButton()
        {
            Time.timeScale = 1f;
            Debug.Log("Go to Menu");
            fader.FadeTo(loadToScene);
        }
        
        public void Continue()
        {
            fader.FadeOutOnly(() =>
            {
                Debug.Log("게임 재개");
                Time.timeScale = 1f;
                gameOverUI.SetActive(false);
                GameManager.Instance.ContinueGame();
            });
        }
        

        
    }
}