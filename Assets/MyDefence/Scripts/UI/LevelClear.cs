using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace MyDefence
{
    public class LevelClear : MonoBehaviour
    {
        [SerializeField] GameObject levelClearUI;
        //[SerializeField] TextMeshProUGUI levelText;


        //private void Start()
        //{
        //    int currentLevel = PlayerPrefs.GetInt("CurrentLevel", 1);
        //    levelText.text = currentLevel.ToString();
        //}
        public void OnContinueButton()
        {
            Time.timeScale = 1f;
            int nextScene = SceneManager.GetActiveScene().buildIndex + 1;

            if(nextScene < SceneManager.sceneCountInBuildSettings)
            {
                SceneManager.LoadScene(nextScene);
            }
            else
            {
                Debug.Log("마지막 레벨입니다 메인메뉴로 돌아갑니다.");
                SceneManager.LoadScene("MainMenu");
            }
            
        }

        public void OnMenuButton()
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("MainMenu");
        }
        //public void LevelButtonSelect(string sceneName)
        //{
        //    int level = int.Parse(sceneName.Replace("Level", "")); // "Level05" → 5
        //    PlayerPrefs.SetInt("CurrentLevel", level);
            
        //}
    }
    
    
}