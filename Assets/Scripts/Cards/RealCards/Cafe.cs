using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cafe : RedCards
{
    List<int> activationCost;
    int costCards;

    string cardName;

    public Cafe()
    {
        this.activationCost = new List<int>() { 3 };
        this.costCards = 2;
        this.cardName = "Cafe";
    }

    public override void effectCards()
    {

    }
}
