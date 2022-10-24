using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forêt : BlueCards
{
    List<int> activationCost;
    int costCards;

    string cardName;

    public Forêt()
    {
        this.activationCost = new List<int>() { 5 };
        this.costCards = 3;
        this.cardName = "Forêt";
    }

    public override void effectCards()
    {

    }
}
