using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restaurant : RedCards
{
    readonly List<int> activationCost;
    readonly int costCards;

    readonly string cardName;

    public Restaurant()
    {
        this.activationCost = new List<int>() { 9, 10 };
        this.costCards = 3;
        this.cardName = "Restaurant";
    }

    public override void effectCards(Player p, List<Player> enemy)
    {

    }
}
