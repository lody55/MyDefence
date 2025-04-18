using UnityEngine;
namespace MyDefence
{
    public class LookAtCamera : MonoBehaviour
    {
        //무조건 카메라를 향해 바라본다
        #region Field
        private Camera m_MainCamera;

        #endregion
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            m_MainCamera = Camera.main;
        }

        // Update is called once per frame
        void Update()
        {
            transform.LookAt(m_MainCamera.transform);
        }
    }
}