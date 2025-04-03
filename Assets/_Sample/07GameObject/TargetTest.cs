using UnityEngine;
namespace Sample
{

    
    public class TargetTest : MonoBehaviour
    {
        #region Field
        private int a = 10;
        public int b = 20;


        #endregion
        public int GetA()
        {
            return a;
        }
        public void SetA(int _a)
        {
            this.a = _a;
        }
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}