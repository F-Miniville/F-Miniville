using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cafe : RedCards
{
    public Cafe(List<int> activationCost, int costCards, string cardName, string color) : base(activationCost, costCards, cardName, color)
    {

    }

    public override void effectCards(Player p, List<Player> enemy, int result)
    {
        if (activationCost.Contains(result))
        {
            GameObject currentPlayer = Game.instance.playerTurn;
            Player currentPlayerScript = currentPlayer.GetComponent<Player>();

            int peGold = currentPlayerScript.Gold;

            if (peGold >= 1)
            {
                int add = 1;
                foreach (Etablissement etablissement in p.etablissements)
                {
                    if (etablissement.GetType().ToString() == "Centrecommercial")
                    {
                        add++;
                        break;
                    }
                }
                p.earnGold(add);
                currentPlayerScript.spendGold(1);
            }
        }
    }
}
