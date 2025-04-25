using UnityEngine;
using UnityEngine.SceneManagement;
namespace MyDefence
{
    public class GameManager : MonoBehaviour
    {
        #region Field
        
        public bool isCheat = false;

        public GameObject gameOverUI;
        public GameObject levelClearUI;
        private static bool isGameOver = false;
        private bool isPaused;

        //레벨 클리어
        //[SerializeField]private int unLockLevel = 2;
        [SerializeField] GameObject gameClearUI;
        #endregion

        #region Property
        public static bool IsGameOver
        {
            get { return isGameOver; }
        }
        public static GameManager Instance { get; private set; }
        #endregion

        private void Start()
        {
            isGameOver = false;
            Instance = this;
        
        }

        private void Update()
        {
            //게임 오버 체크
            if (IsGameOver)
                return;

            //게임오버 되었는지 체크
            if (PlayerStats.Life <= 0)
            {
                GameOver();
            }

            //Cheating
            //M키를 누르면 10만골드 지급
            //if (Input.GetKeyDown(KeyCode.M))
            //{
            //    ShowMeTheMoney();
            //}
            if (Input.GetKeyDown(KeyCode.O) && isCheat == true)
            {
                Debug.Log("O 키 눌림 + 치트 활성화됨");
                GameOver();
            }
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (isPaused)
                    Resume();
                else
                    Pause();
            }
        }
        //void ShowMeTheMoney()
        //{
        //    if (isCheat == false)
        //        return;
        //    PlayerStats.AddMoney(1000000);
        //}
        public void GameOver()
        {
            isGameOver = true;

            gameOverUI.SetActive(true);
            //levelClearUI.SetActive(true);
            
        }
        public void LevelClear()
        {
            //데이터 처리 - 보상,레벨저장
            //저장되어 있는 데이터 가져오기 
            int nowLevel = PlayerPrefs.GetInt("NowLevel", 1);
            int currentLevelIndex = SceneManager.GetActiveScene().buildIndex;
            if (nowLevel <= currentLevelIndex)
            {
                PlayerPrefs.SetInt("NowLevel", currentLevelIndex + 1); // 다음 레벨을 열어줌
                PlayerPrefs.Save(); // 저장
            }

                //UI보여주기

                Debug.Log("Level Clear");
            gameClearUI.SetActive(true);
        }

        public void Pause()
        {
            Time.timeScale = 0f;
            isPaused = true;
            gameOverUI.SetActive(true);
        }
        public void Resume()
        {
            Time.timeScale = 1f;
            isPaused = false;
            gameOverUI.SetActive(false);
        }
        public void ContinueGame()
        {
            isGameOver = false;
        }

    }
}