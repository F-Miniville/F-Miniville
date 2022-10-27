using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Centredaffaires : PurpleCards
{
    public Centredaffaires(List<int> activationCost, int costCards, string cardName, string color) : base(activationCost, costCards, cardName, color)
    {

    }

    public override void effectCards(Player p, List<Player> enemy, int result)
    {
        if (activationCost.Contains(result))
            Debug.Log("Vous pouvez échanger avec  le joueur de votre choix un établissement qui ne soit pas de type violet");
    }
}
