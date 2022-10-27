using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chainedetele : PurpleCards
{
    public Chainedetele(List<int> activationCost, int costCards, string cardName, string color) : base(activationCost, costCards, cardName, color)
    {

    }

    public override void effectCards(Player p, List<Player> enemy, int result)
    {    
        if (activationCost.Contains(result))
        {
            //demander de quel joueur recevoir les pièces
            //GameObject currentPlayer = Game.instance.playerTurn;
            //Player currentPlayerScript = currentPlayer.GetComponent<Player>();

            /*
            int totalGold = 0;

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
            */
            Debug.Log("Recevez 5 pièces du joueur de votre choix");
        }
    }
}
