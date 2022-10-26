using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEditor;

public class Game : MonoBehaviour
{
<<<<<<< Updated upstream
    public List<Player> players = new List<Player>();
=======
>>>>>>> Stashed changes

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
<<<<<<< Updated upstream
            foreach (Player p in players)
            {
                Debug.Log("Creation liste enemy");
                List<Player> enemy = new List<Player>();
                foreach (Player e in players)
                {
                    if (e != p)
                    {
                        enemy.Add(e);
                    }
                }
                Debug.Log("Appelle de la fonction Turn()");
                Turn(p, enemy);
                int compteurVictoire = 0;
                foreach (KeyValuePair<Etablissement, bool> keyValuePair in p.Etablissement)
                {
                    if (keyValuePair.Value == true)
                    {
                        compteurVictoire++;
                    }
                }

                if (compteurVictoire >= 4)
                {
                    fin = false;
                }
            }
=======
            Instantiate(player);
>>>>>>> Stashed changes
        }

        _PlayerScript = _Player.GetComponent<Player>();
        _IAScript = _IA.GetComponent<Player>();
    }

    public void Update()
    {
<<<<<<< Updated upstream
        List<Cards> cards = new List<Cards>();
        List<Player> newEnemy = new List<Player>();

        Debug.Log("Calcule result Dices");
        int result;
        oneMoreDice = false;
        List<Dice> dice = p.Dices;
        if (dice.Count > 1)
        {
            oneMoreDice = true;
        }
        diceManager.AlreadyClick = false;
        while (diceManager.Result == 0) { Debug.Log("Wait Result"); }
        result = diceManager.Result;
        Debug.Log("Fin Calcule result Dices");

        foreach (Player player in players)
        {
            newEnemy.Clear();
            foreach (Player e in players)
            {
                if (e != player)
                {
                    newEnemy.Add(e);
                }
            }
            cards.Clear();
            foreach (KeyValuePair<Cards, int> keyValuePair in player.Cards)
            {
                for (int i = 0; i < keyValuePair.Value; i++)
                {
                    cards.Add(keyValuePair.Key);
                }
            }
            foreach (BlueCards blueCards in cards)
=======
        do
        {
            TourPlayer();
            if(CheckWin(_PlayerScript) < 4)
            {
                break;    
            }

            TourIA();
            if (CheckWin(_IAScript) < 4)
>>>>>>> Stashed changes
            {
                break;
            }

        }
        while (true);

        Debug.Log("Fin boucle tour");
        //Condition de fin

<<<<<<< Updated upstream
        foreach(Player player in enemy)
        {
            newEnemy.Clear();
            foreach (Player e in players)
            {
                if (e != player)
                {
                    newEnemy.Add(e);
                }
            }
            cards.Clear();
            foreach (KeyValuePair<Cards, int> keyValuePair in player.Cards)
            {
                for (int i = 0; i < keyValuePair.Value; i++)
                {
                    cards.Add(keyValuePair.Key);
                }
            }
            foreach (RedCards redCards in cards)
            {
                if (redCards.ActivationCost.Contains(result))
                {
                    redCards.effectCards(p, enemy);
                }
            }
        }

        newEnemy.Clear();
        foreach (Player e in players)
        {
            if (e != p)
            {
                newEnemy.Add(e);
            }
        }
        cards.Clear();
        foreach (KeyValuePair<Cards, int> keyValuePair in p.Cards)
        {
            for (int i = 0; i < keyValuePair.Value; i++)
            {
                cards.Add(keyValuePair.Key);
            }
        }
        foreach (GreenCards greenCards in cards)
        {
            if (greenCards.ActivationCost.Contains(result))
            {
                greenCards.effectCards(p, enemy);
            }
        }
        foreach (PurpleCards purpleCards in cards)
=======
        

    }

    //Vérifie la condition de victoire du joueur donné
    public int CheckWin(Player p)
    {
        int win = 0;

        foreach(Etablissement etablissement in p.etablissements)
>>>>>>> Stashed changes
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
