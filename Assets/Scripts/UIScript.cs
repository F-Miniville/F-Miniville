using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIScript : MonoBehaviour
{
    [SerializeField] string sceneToLoad;
    public void QuitGame()
    {
        //on rajoute ces quelques lignes pour pouvoir tester le bouton Exit sur Unity
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
                Application.Quit(); //fonctionne seul pour un build
#endif
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(sceneToLoad);
    }

    public void Credit()
    {
        SceneManager.LoadScene("Credit");
    }

    public void Continue()
    {
        Debug.Log("Continue ok !"); //waiting for code..
    }

    public void MenuReturn()
    {
        SceneManager.LoadScene("Menu");
    }
}
