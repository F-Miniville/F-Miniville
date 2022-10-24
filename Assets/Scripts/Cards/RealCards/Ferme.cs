using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ferme : BlueCards
{
    readonly List<int> activationCost;
    readonly int costCards;

    readonly string cardName;

    public Ferme()
    {
        this.activationCost = new List<int>() { 2 };
        this.costCards = 1;
        this.cardName = "Ferme";
    }

    public override void effectCards()
    {

    }
}
