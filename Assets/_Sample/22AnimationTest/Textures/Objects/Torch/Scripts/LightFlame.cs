using System.Collections;
using UnityEngine;
namespace Sample
{
    public class LightFlame : MonoBehaviour
    {
        [SerializeField] Animator animator;
        private string[] flameLight = { "LightAnim", "LightAnim2", "LightAnim3" };

        private int lightMode = 0;
        void Start()
        {
            
            //InvokeRepeating(nameof(RandomPlay), 0f, 1f);
            lightMode = 0;
        }

        // Update is called once per frame
        void Update()
        {
            StartCoroutine(RandomStart());
        }

        void RandomPlay()
        {
            int index = Random.Range(0, flameLight.Length);
            string aniAni = flameLight[index];
            animator.Play(aniAni);
        }
        IEnumerator RandomStart()
        {
            lightMode = Random.Range(1, 4);
            animator.SetInteger("LightMod", lightMode);
            //switch(lightMode)
            //{
            //    case 1:
            //        animator.SetInteger("Lightmode", 1);
            //        break;
            //    case 2:
            //        animator.SetInteger("Lightmode", 2);
            //        break;
            //    case 3:
            //        animator.SetInteger("Lightmode", 3);
            //        break;
            //}

            yield return new WaitForSeconds(0.99f);
            lightMode = 0;
        }
    }
}