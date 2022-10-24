using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cafe : RedCards
{
    int activationCost;
    int costCards;

    string cardName;

    public Cafe()
    {
        this.activationCost = 3;
        this.costCards = 2;
        this.cardName = "Cafe";
    }

    public override void effectCards()
    {

    }
}
