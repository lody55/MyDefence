using UnityEngine;
namespace Sample
{
    public class FactoryTest : MonoBehaviour 
    {
        
        private void Start()
        {
            //심플 팩토리 객체 생성
            //MonsterFactory monsterFactory = new MonsterFactory();

            ////슬라임 생성
            //Monster slime =  monsterFactory.CreateMonster(MonsterType.Slime);
            //slime.Attack();
            //Monster Zombie = monsterFactory.CreateMonster(MonsterType.Zombie);
            //Zombie.Attack();

            //팩토리 메서드 패턴
            //슬라임 전용 공장
            SlimeFactory slimeFactory = new SlimeFactory();
            Monster slime = slimeFactory.CreatMonster();
            slimeFactory.SlimeCount();
            slime.Attack();

            //좀비 전용 공장
            ZombieFactory zombieFactory = new ZombieFactory();
            Monster zombie = zombieFactory.CreatMonster();
            zombieFactory.AddSomething();
            zombie.Attack();

            //스켈레톤 전용공장
            SkeletonFactory skeletonFactory = new SkeletonFactory();
            Monster skeleton = skeletonFactory.CreatMonster();
            skeleton.Attack();
        }
    }
}