using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restaurant : RedCards
{
    public Restaurant(List<int> activationCost, int costCards, string cardName, string color) : base(activationCost, costCards, cardName, color)
    {

    }

    public override void effectCards(Player p, List<Player> enemy, int result)
    {
        if (activationCost.Contains(result))
        {
            
            int totalGold = 0;
            GameObject currentPlayer = Game.instance.playerTurn;
            Player currentPlayerScript = currentPlayer.GetComponent<Player>();

            int peGold = currentPlayerScript.Gold;
            if (peGold >= 2)
            {
                totalGold += 2;
                currentPlayerScript.spendGold(2);
            }
            else if (peGold == 1)
            {
                totalGold += 1;
                currentPlayerScript.spendGold(1);
            }

            p.earnGold(totalGold);
        }
    }
}
