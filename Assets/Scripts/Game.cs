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
        while (true)
        {
            foreach (Player p in players)
            {
                List<Player> enemy = new List<Player>();
                foreach (Player e in players)
                {
                    if (e != p)
                    {
                        enemy.Add(e);
                    }
                }
                Turn(p, enemy);
            }

        }

    }



    public void Turn(Player p, List<Player> enemy)
    {
        List<Cards> cards = new List<Cards>();
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
                    blueCards.effectCards();
                }
            }
        }
        foreach(Player player in enemy)
        {
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
                    redCards.effectCards();
                }
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
                greenCards.effectCards();
            }
        }

    }

}
