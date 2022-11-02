using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIScript : MonoBehaviour
{
    public static UIScript instance;

    public void Awake()
    {
        if(instance != null)
        {
            Debug.Log("Il y a plus d'une instance de UIScript dans la scene");
            return;
        }
        instance = this;

        _AudioManager = GameObject.FindWithTag("AudioManager");
    }

    [SerializeField] string sceneToLoad;
    public GameObject _AudioManager;
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
        DontDestroyOnLoad(_AudioManager);
        SceneManager.LoadScene(sceneToLoad);
    }

    public void Credit()
    {
        DontDestroyOnLoad(_AudioManager);
        SceneManager.LoadScene("Credit");
    }

    public void MenuReturn()
    {
        ChoiceNbPlayer.Instance.DestroyNbPlayerManager();
        SceneManager.LoadScene(0);
    }

    public void ReturnMenuFromCredit()
    {
        SceneManager.LoadScene("Menu");
    }
}
