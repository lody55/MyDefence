using System;
using System.Collections;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

namespace Sample
{
    public class PrefabTest : MonoBehaviour
    {
        public GameObject TilePrefab; // 프리팹 연결

        void Start()
        {
            //Vector3 position = new Vector3(0f, 0f, 0f);

            //10 x 10 생성
            //GenerateMap2(10,10);

            //[2] n(10) , m(10) 생성 - 5x5 , 7x7
            //GenerateMap2(10,10);

            //[3] 타일을 생성 - x좌표를 0~500사이의 랜덤값, y = 0 , z좌표를 -500f ~ 0사이의 랜덤값
            // for (int i = 0; i < 10; i++)
            // { RandomTile(); }

            //[4] 타일을 10개 생성, 타일 하나 생성할 때 딜레이 0.2초(코루틴)
            StartCoroutine(RandomTile());



        }
        IEnumerator RandomTile()
        {

            for (int i = 0; i < 10; i++)
            { float randx = UnityEngine.Random.Range(0f, 50f);
                float randz = UnityEngine.Random.Range(-50f, 0f);
                Vector3 position = new Vector3(randx, 0f, randz);
                Instantiate(TilePrefab, position, Quaternion.identity);

                yield return new WaitForSeconds(0.2f); 
            }
        }
        void GenerateMap(int row, int column)
        {
            for (int i = 0; i <row; i++)
            {
                for (int y = 0; y < column; y++)
                {
                    Vector3 position = new Vector3(i * 5f, 0f, y * -5f);
                    Instantiate(TilePrefab, position, Quaternion.identity);
                    
                }
            }
        }
        void GenerateMap2(int row, int column)
        {
            for (int i = 0; i < row; i++)
            {
                for (int y = 0; y < column; y++)
                {
                   GameObject go = Instantiate(TilePrefab);
                    go.transform.position = new Vector3(y * 5f, 0f, i * 5f);
                    
                }
            }
        }
    }
}
/*
 타일을 10 x 10으로 배치
 */