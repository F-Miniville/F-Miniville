using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Verger : BlueCards
{
    readonly List<int> activationCost;
    readonly int costCards;

    readonly string cardName;

    public Verger()
    {
        this.activationCost = new List<int>() { 10 };
        this.costCards = 3;
        this.cardName = "Verger";
    }

    public override void effectCards()
    {

    }
}
