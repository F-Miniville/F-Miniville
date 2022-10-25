using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEditor;

public class Game : MonoBehaviour
{
    private List<Player> players = new List<Player>();
    public List<Player> Players { get; set; }

    public DiceManager diceManager;
    private bool oneMoreDice;
    public bool OneMoreDice { get; }

    public void Start()
    {
        bool fin = true;
        while (fin)
        {
            foreach (Player p in Players)
            {
                List<Player> enemy = new List<Player>();
                foreach (Player e in Players)
                {
                    if (e != p)
                    {
                        enemy.Add(e);
                    }
                }
                Turn(p, enemy);
                int compteurVictoire = 0;
                foreach(KeyValuePair<Etablissement, bool> keyValuePair in p.Etablissement)
                {
                    if(keyValuePair.Value == true)
                    {
                        compteurVictoire++;
                    }
                }
                if(compteurVictoire >= 4)
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
        int result;
        oneMoreDice = false;
        if (p.Dices.Count > 1)
        {
            oneMoreDice = true;
        }
        diceManager.AlreadyClick = false;
        while (diceManager.Result == 0) { Debug.Log("Wait Result"); }
        result = diceManager.Result;

        foreach(Player player in players)
        {
            newEnemy.Clear();
            foreach (Player e in Players)
            {
                if (e != player)
                {
                    newEnemy.Add(e);
                }
            }
            cards.Clear();
            foreach(KeyValuePair<Cards, int> keyValuePair in player.Cards)
            {
                for(int i = 0; i < keyValuePair.Value; i++)
                {
                    cards.Add(keyValuePair.Key);
                }
            }
            foreach(BlueCards blueCards in cards)
            {
                if (blueCards.ActivationCostList.Contains(result))
                {
                    blueCards.effectCards(player, newEnemy);
                }
            }
        }
        foreach(Player player in enemy)
        {
            newEnemy.Clear();
            foreach (Player e in Players)
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
                if (redCards.ActivationCostList.Contains(result))
                {
                    redCards.effectCards(player, newEnemy);
                }
            }
        }

        newEnemy.Clear();
        foreach (Player e in Players)
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
        foreach(GreenCards greenCards in cards)
        {
            if (greenCards.ActivationCostList.Contains(result))
            {
                greenCards.effectCards(p, newEnemy);
            }
        }
        foreach(PurpleCards purpleCards in cards)
        {
            if (purpleCards.ActivationCostList.Contains(result))
            {
                purpleCards.effectCards(p, newEnemy);
            }
        }

        Boutique(p);

    }

    public void Boutique(Player p)
    {

    }

}
