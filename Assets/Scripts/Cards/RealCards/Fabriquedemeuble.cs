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
            foreach (Mine mine in p.cards)
                i++;
            foreach (For�t for�t in p.cards)
                i++;

            p.earnGold(i);
        }
    }
}
