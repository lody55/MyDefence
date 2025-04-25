using UnityEngine;
namespace Sample
{
    //몬스터의 타입 정의
    public enum MonsterType
    {
        Slime,
        Zombie,
        Goblin
    }
    //모든 몬스터의 부모 추상 클래스
    public abstract class Monster
    {
        //몬스터의 속성, 몬스터의 기능 정의, 구현

        public abstract void Attack();
        
    }
    //슬라임을 관리하는 클래스
    public class Slime : Monster
    {
        public override void Attack()
        {
            Debug.Log("슬라임 공격");
        }
    }
    public class Zombie : Monster
    {
        public override void Attack()
        {
            Debug.Log("좀비 공격");
        }
    }
    public class Goblin : Monster
    {
        public override void Attack()
        {
            Debug.Log("고블린 공격");
        }
    }
    public class Skeleton : Monster
    {
        public override void Attack()
        {
            Debug.Log("스켈레톤 공격");
        }
    }
}

/*
 팩토리 패턴
1. - 심플 팩토리

2. - 팩토리 메서드 패턴
    - 심플 팩토리 확장
    - 팩토리에서 기능 추가

3. - 추상 팩토리 패턴
    - 심플 팩토리 확장
    - 여러개의 객체가 생성
 
 */