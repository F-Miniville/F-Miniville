using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEditor;

public class Game : MonoBehaviour
{

    //Gestion des joueurs
    List<GameObject> _PlayersList;
    GameObject _Player;
    Player _PlayerScript;
    [SerializeField] GameObject PlayerPrefab;
    GameObject _IA;
    Player _IAScript;
    [SerializeField] GameObject IAPrefabs;

    //Gestion des dé
    GameObject _DiceManager;
    DiceManager _DiceManagerScript;
    [SerializeField] GameObject DiceManagerPrefabs;



    public void Start()
    {
        _PlayersList = new List<GameObject>() { PlayerPrefab, IAPrefabs };

        _Player = _PlayersList[0];
        _IA = _PlayersList[1];
        foreach(GameObject player in _PlayersList)
        {
            Instantiate(player);
        }

        _PlayerScript = _Player.GetComponent<Player>();
        _IAScript = _IA.GetComponent<Player>();
    }

    public void Update()
    {

    }

    //Vérifie la condition de victoire du joueur donné
    public int CheckWin(Player p)
    {
        int win = 0;

        foreach(Etablissement etablissement in p.etablissements)
        {
            win++;
        }

        return win;
    }

    public void TourPlayer()
    {
        foreach(BlueCards blueCards in _PlayerScript.cards)
        {
            Debug.Log("BlueCards");
        }
    }

    public void TourIA()
    {

    }

}
