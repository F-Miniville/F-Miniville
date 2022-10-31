using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChoiceNbPlayer : MonoBehaviour
{
    public static ChoiceNbPlayer Instance;

    public int nbPlayerChoice;
    [SerializeField] string sceneToLoad;
    GameObject _AudioManager;
    public bool _haveIA;

    private void Awake()
    {
        if(Instance != null)
        {
            Debug.Log("Il y a plus d'une instance de ChoiceNbPlayer dans la scene");
            return;
        }
        Instance = this;

        _AudioManager = UIScript.instance._AudioManager;
    }

    public void TwoPlayer()
    {
        nbPlayerChoice = 2;
        UpdateNbPlayer();
    }

    public void ThreePlayer()
    {
        nbPlayerChoice = 3;
        UpdateNbPlayer();
    }

    public void FourPlayer()
    {
        nbPlayerChoice = 4;
        UpdateNbPlayer();
    }

    private void UpdateNbPlayer()
    {
        Destroy(_AudioManager);
        DontDestroyOnLoad(this.gameObject);
        SceneManager.LoadScene(sceneToLoad);
    }

    public void DestroyNbPlayerManager()
    {
        Destroy(this.gameObject);
    }

    public void PlayerVSIA()
    {
        nbPlayerChoice = 1;
        _haveIA = true;
        UpdateNbPlayer();
    }
}
