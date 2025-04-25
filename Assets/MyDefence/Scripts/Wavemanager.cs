using UnityEngine;
using System.Collections;
using TMPro;
using UnityEngine.UI;
namespace MyDefence
{
    public class Wavemanager : MonoBehaviour
    {
        public Wave[] waves;       //웨이브 데이터 세팅 : 적 프리펩, 생성할 갯수
        //public GameObject enemyPrefab;
        public Transform startPoint;
        //private float countdown = 0f;
        private int waveCount = 0;
        public float waveTimer = 5f;

        //게임 매니져
        public GameManager gameManager;
        
        public static int enemyAlive = 0;      //현재 게임 화면에 살아있는 enemy 숫자

        [SerializeField] GameObject startButton;
        [SerializeField] GameObject waveInfo;

        //UI Countdown Text
        public TextMeshProUGUI countdownText;
        private int enemyCount;     //웨이브 생성할 갯수

        private void Start()
        {
            //초기화
            //countdown = 3f;
            waveCount = 0;
            enemyAlive = 0;
            
        }

        void Update()
        {
            //현재 맵에 enemy가 있는지 여부 체크
            if (enemyAlive > 0)
            {
                countdownText.text = enemyAlive.ToString() + "/" + enemyCount.ToString();
                //현재 살아있는 적의 갯수 / 웨이브에서 생성할 갯수
                return; 
            }
            else
            {
                //레벨 클리어 체크
                if (waveCount >= waves.Length)
                {
                    gameManager.LevelClear();
                    this.enabled = false;
                    return;
                }

                //start UI 세팅
                if (waveInfo.activeSelf)
                {
                    startButton.SetActive(true);
                    waveInfo.SetActive(false);
                }
            }
                
            
            //countdown += Time.deltaTime;

            //if (countdown >= waveTimer && waveCount < waves.Length)
            //{
                
            //   // StartCoroutine(SponEnemy());
            //    countdown = waveTimer;
            //}
            
            ////UI
            //countdownText.text = Mathf.Round(countdown).ToString();
        }

        IEnumerator SponEnemy()
        {
            //if(waveCount >= waves.Length)
            //{
            //    this.enabled = false;
            //    yield break;
            //}
            Wave wave = waves[waveCount];
            enemyCount = wave.count;
            enemyAlive = wave.count;

            //라운드 카운트
            PlayerStats.Rounds++;

            for (int i = 0; i < wave.count; i++)
            {
                SpawnEnemy(wave.enemyPrefab);
                yield return new WaitForSeconds(wave.delayTime);
            }
            waveCount++;
            //if(wavecount < waves.length -1)
            //{
            //    wavecount++;
            //}
            //else
            //{
            //    debug.log("wave clear");
            //    this.enabled = false;
            //}

        }


        void SpawnEnemy(GameObject gameObject)
        {
            Instantiate(gameObject, startPoint.position, Quaternion.identity);
           
            
        }
        public void WaveStart()
        {
            startButton.SetActive(false);
            waveInfo.SetActive(true);
            StartCoroutine(SponEnemy());
            
        }
        
    }
}