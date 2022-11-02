using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fabriquedemeuble : GreenCards
{
    public Fabriquedemeuble(List<int> activationCost, int costCards, string cardName, string color) : base(activationCost, costCards, cardName, color)
    {

    }

    public override void effectCards(Player p, List<Player> enemy, int result)
    {
        if (activationCost.Contains(result))
        {
            int i = 0;
            foreach (Cards foret in p.cards)
            {
                if (foret.GetType().ToString() == "Forêt")
                {
                    i += 3;
                }
            }
            foreach (Cards mine in p.cards)
            {
                if (mine.GetType().ToString() == "Mine")
                {
                    i += 3;
                }
            }

            p.earnGold(i);
        }
    }
}
