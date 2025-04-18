using UnityEngine;
namespace Solid
{
    public class Player : MonoBehaviour
    {
        //플레이어를 관리하는 클래스

        private PlayerInput m_PlayerInput;
        private PlayerMovement dsa;
        private PalyerAudio asd;
        private PlayerFX sdfgg;

        private void Start()
        {
            m_PlayerInput = GetComponent<PlayerInput>();
            dsa = GetComponent<PlayerMovement>();
            asd = GetComponent<PalyerAudio>();
            sdfgg = GetComponent<PlayerFX>();
        }

    }
}