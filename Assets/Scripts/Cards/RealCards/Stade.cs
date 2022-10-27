using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stade : BlueCards
{
    public Stade(List<int> activationCost, int costCards, string cardName, string color) : base(activationCost, costCards, cardName, color)
    {

    }

    public override void effectCards(Player p, List<Player> enemy, int result)
    {
        if (activationCost.Contains(result))
        {
            int totalGold = 0;
            foreach (Player pe in enemy)
            {
                int peGold = pe.Gold;
                if (peGold >= 2)
                {
                    totalGold += 2;
                    pe.spendGold(2);
                }
                else if (peGold == 1)
                {
                    totalGold += 1;
                    pe.spendGold(1);
                }
            }

            p.earnGold(totalGold);
        }
    }
}
