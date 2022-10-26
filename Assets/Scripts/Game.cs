using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEditor;

public class Game : MonoBehaviour
{
    public List<Player> players = new List<Player>();

    public DiceManager diceManager;
    private bool oneMoreDice;
    public bool OneMoreDice { get; }

    public void Start()
    {
        bool fin = true;
        while (fin)
        {
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

<<<<<<< Updated upstream
                if(compteurVictoire >= 4)
=======
                if (compteurVictoire >= 4)
>>>>>>> Stashed changes
                {
                    fin = false;
                }
            }
        }

    }



    public void Turn(Player p, List<Player> enemy)
    {
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
            {
                if (blueCards.ActivationCost.Contains(result))
                {
                    blueCards.effectCards(p, enemy);
                }
            }
        }


<<<<<<< Updated upstream
        foreach(Player player in enemy)
=======
        foreach (Player player in enemy)
>>>>>>> Stashed changes
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
        {
            if (purpleCards.ActivationCost.Contains(result))
            {
                purpleCards.effectCards(p, enemy);
            }
        }

        Boutique(p);

    }

    public void Boutique(Player p)
    {

    }

}
