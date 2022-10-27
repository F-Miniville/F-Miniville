using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Superette : GreenCards
{
    public Superette(List<int> activationCost, int costCards, string cardName, string color) : base(activationCost, costCards, cardName, color)
    {

    }

    public override void effectCards(Player p, List<Player> enemy, int result)
    {
        Debug.Log("Superette effectCards");
    }
}
