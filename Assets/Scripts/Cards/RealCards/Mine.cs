using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mine : BlueCards
{
    public Mine(List<int> activationCost, int costCards, string cardName, string color) : base(activationCost, costCards, cardName, color)
    {

    }

    public override void effectCards(Player p, List<Player> enemy)
    {
        Debug.Log("Mine effectCards");
    }
}
