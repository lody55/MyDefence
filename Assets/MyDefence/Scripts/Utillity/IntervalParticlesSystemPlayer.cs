using System.Collections;
using UnityEngine;
namespace MyDefence
{
    public class IntervalParticlesSystemPlayer : MonoBehaviour
    {
        [SerializeField] ParticleSystem particle;
        [SerializeField] ParticleSystem particles;
        [SerializeField] float raiserInterval = 0.5f;
        [SerializeField] float bb = 1f;
        private void Start()
        {
            
            StartCoroutine(ParticleGo());
        }

        IEnumerator ParticleGo()
        {
            while (true)
            {
                particle.Play();
                yield return new WaitForSeconds(raiserInterval);
                particles.Play();
                yield return new WaitForSeconds(bb);

            }
        }
    }
}