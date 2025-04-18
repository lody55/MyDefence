using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace MyDefence
{
    public class Title : MonoBehaviour
    {
        [SerializeField] int sceneIndex = 0;
        [SerializeField] GameObject anyKey;
        //[SerializeField] float showAnyKey = 3f;
        //[SerializeField] float showLoadMenu = 13f;

        private bool canPressKey = false;

        private void Start()
        {
            anyKey.SetActive(false);
            StartCoroutine(AnykeyText());
        }
        private void Update()
        {
            if(canPressKey && Input.anyKeyDown)
            {
                LoadMenu();
            }
        }
        IEnumerator AnykeyText()
        {
            yield return new WaitForSeconds(3f); 
            anyKey.SetActive(true);
            canPressKey = true;

            yield return new WaitForSeconds(10f);
            LoadMenu();
        }
        void LoadMenu()
        {
            SceneManager.LoadScene(sceneIndex);
        }
    }
}