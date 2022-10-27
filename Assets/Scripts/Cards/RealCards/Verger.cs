using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Verger : BlueCards
{
    public Verger(List<int> activationCost, int costCards, string cardName, string color) : base(activationCost, costCards, cardName, color)
    {

    }

    public override void effectCards(Player p, List<Player> enemy, int result)
    {
        if (activationCost.Contains(result))
        {
            p.earnGold(3);
        }
    }
}
