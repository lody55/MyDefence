using UnityEngine;
using System.Collections;
using TMPro;
namespace MyDefence
{
    public class Wavemanager : MonoBehaviour
    {
        public GameObject EnemyPrefab;
        public Transform startPoint;
        private float countdown = 0f;
        private int waveCount = 0;

        //UI Countdown Text
        public TextMeshProUGUI countdownText;

        private void Start()
        {
            //초기화
            countdown = 0f;
            waveCount = 0;
        }

        void Update()
        {
            countdown += Time.deltaTime;

            if (countdown >= 5)
            {
                waveCount++; // 
                StartCoroutine(SponEnemy(waveCount));

                
                countdown = 0f;
            }
            //UI
            countdownText.text = Mathf.Round(countdown).ToString();
        }



        IEnumerator SponEnemy(int count)
        {
            for (int i = 0; i < count; i++)
            {
                
                

                Instantiate(EnemyPrefab, startPoint.position, Quaternion.identity);
                //Debug.Log($"[{waveCount} 웨이브] {i + 1}번 적 생성");

                yield return new WaitForSeconds(0.3f); 
            }
        }
    }
}