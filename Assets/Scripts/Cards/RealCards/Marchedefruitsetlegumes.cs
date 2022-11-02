using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marchedefruitsetlegumes : GreenCards
{
    public Marchedefruitsetlegumes(List<int> activationCost, int costCards, string cardName, string color) : base(activationCost, costCards, cardName, color)
    {

    }

    public override void effectCards(Player p, List<Player> enemy, int result)
    {
        if (activationCost.Contains(result))
        {
            int i = 0;
            foreach (Cards champsdeble in p.cards)
            {
                if(champsdeble.GetType().ToString() == "Champsdeble")
                {
                    i += 2;
                }
            }
            foreach (Cards verger in p.cards)
            {
                if(verger.GetType().ToString() == "Verger")
                {
                    i += 2;
                }
            }

            p.earnGold(i);
        }
    }
}
