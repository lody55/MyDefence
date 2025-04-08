using System;
using UnityEngine;
namespace MyDefence
{

    //타워 속성(데이터) 정의 직렬화 클래스
    [Serializable]
    public class TowerBluePrint
    {
        public GameObject towerPrefab; // 타워 건설에 필요한 프리펩
        public int cost;		// 타워 건설 비용
    }
}