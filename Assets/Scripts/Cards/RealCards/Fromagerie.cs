using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Fromagerie : GreenCards
{
    public Fromagerie(List<int> activationCost, int costCards, string cardName, string color) : base(activationCost, costCards, cardName, color)
    {

    }

    public override void effectCards(Player p, List<Player> enemy, int result)
    {
        if (activationCost.Contains(result))
        {
            int i = 0;
            foreach (Cards ferme in p.cards)
            {
                if(ferme.GetType().ToString() == "Ferme")
                {
                    i += 3;
                }
            }

            p.earnGold(i);
        }
    }
}
