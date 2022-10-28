using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChoiceNbPlayer : MonoBehaviour
{
    public static ChoiceNbPlayer Instance;
    private void Awake()
    {
        if(Instance != null)
        {
            Debug.Log("Il y a plus d'une instance de ChoiceNbPlayer dans la scene");
            return;
        }
        Instance = this;
    }

    public int nbPlayerChoice;
    [SerializeField] string sceneToLoad;
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
        DontDestroyOnLoad(this.gameObject);
        SceneManager.LoadScene(sceneToLoad);
    }

}
