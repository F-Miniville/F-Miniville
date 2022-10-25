using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mine : BlueCards
{
    readonly List<int> activationCost;
    readonly int costCards;

    readonly string cardName;

    public Mine()
    {
        this.activationCost = new List<int>() { 9 };
        this.costCards = 6;
        this.cardName = "Mine";
    }

    public override void effectCards(Player p, List<Player> enemy)
    {

    }
}
