using System.Threading;
using UnityEngine;
namespace Sample
{
    //팩토리 메서드 패턴
    //생성하는 메서드를 추상화 한다
    public interface IMonsterFactory 
    {
        public Monster CreatMonster();


    }
    //슬라임을 생성하는 전용 팩토리
    public class SlimeFactory : IMonsterFactory
    {
        int count = 0;
        public Monster CreatMonster()
        {
            return new Slime();
        }
        public void SlimeCount() => count++;
    }

    //좀비를 생성하는 전용 팩토리
    public class ZombieFactory : IMonsterFactory
    {
        public Monster CreatMonster()
        {
            return new Zombie();
        }
        public void AddSomething()
        {
            Debug.Log("다른 무언가");
        }
    }
    public class SkeletonFactory : IMonsterFactory
    {
        public Monster CreatMonster()
        {
            return new Skeleton();
        }

        
    }
}