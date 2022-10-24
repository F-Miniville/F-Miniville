using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stade : BlueCards
{
    List<int> activationCost;
    int costCards;

    string cardName;

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
