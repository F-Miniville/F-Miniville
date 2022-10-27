using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boulangerie : GreenCards
{
    public Boulangerie(List<int> activationCost, int costCards, string cardName, string color) : base(activationCost, costCards, cardName, color)
    {

    }

    public override void effectCards(Player p, List<Player> enemy, int result)
    {
        Debug.Log("Boulangerie effectCards");
    }
}
