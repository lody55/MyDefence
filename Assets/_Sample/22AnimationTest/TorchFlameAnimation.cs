using System.Collections;
using UnityEngine;
namespace Sample
{
    public class TorchFlameAnimation : MonoBehaviour
    {
        #region Variables
        //라이트 레거시 애니메이션
        [SerializeField] new Animation animation;

        private string[] flameAnim = { "FlameAnim01", "FlameAnim02", "FlameAnim03" };
        #endregion

        private void Start()
        {

            //InvokeRepeating(nameof(RandomPlay), 0f, 1f);
            StartCoroutine(RandomStart());
        }

        void RandomPlay()
        {
            int index = Random.Range(0, flameAnim.Length);
            string animPlay = flameAnim[index];
            animation.Play(animPlay);
        }
        IEnumerator RandomStart()
        {
            while (true)
            {
                RandomPlay();
                yield return new WaitForSeconds(0.99f);
            }
        }
    }
}