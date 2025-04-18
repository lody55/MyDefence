using UnityEngine;
namespace Solid
{
    //플레이어 구현 (플레이어를 관리하는 클래스), 밑 메서드에 있는 내용들을 구현
    //하지만 이렇게 캡슐화를 하지않고 구현하면 복잡하고 알기 어렵다 나중에 혹시 버그 수정 및 가독성 부분에서
    //그렇기 때문에따로 한가지 기능을 주로 담당하게 되는 클래스를 만들어준다 =스크립트
    public class UnRefactoryedPlayer : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        //플레이어 인풋처리
        private void HandleInput()
        {
            //인풋 기능 구현

        }
        //플레이어 이동
        private void Move(Vector3 inputVector)
        {
            //이동 기능 구현
        }
        //플레이어 사운드
        private void PlayerRandomAudioClip()
        {
            //사운드 플레이
        }
        //플레이어와 관련된 이펙트 처리
        private void PlayerEffect()
        {
            //이펙트 구현
        }

    }
}