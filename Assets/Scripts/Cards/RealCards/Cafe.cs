using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cafe : RedCards
{
    readonly List<int> activationCost;
    readonly int costCards;

    readonly string cardName;

    public Cafe()
    {
        this.activationCost = new List<int>() { 3 };
        this.costCards = 2;
        this.cardName = "Cafe";
    }

    public override void effectCards(Player p, List<Player> enemy)
    {

    }
}
