using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Superette : GreenCards
{
    List<int> activationCost;
    int costCards;

    string cardName;

    public Superette()
    {
        this.activationCost = new List<int>() { 4 };
        this.costCards = 2;
        this.cardName = "Superette";
    }

    public override void effectCards()
    {

    }
}
