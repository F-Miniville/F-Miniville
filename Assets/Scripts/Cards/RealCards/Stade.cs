using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stade : BlueCards
{
    readonly List<int> activationCost;
    readonly int costCards;

    readonly string cardName;

    public Stade()
    {
        this.activationCost = new List<int>() { 6 };
        this.costCards = 6;
        this.cardName = "Stade";
    }

    public override void effectCards()
    {

    }
}
