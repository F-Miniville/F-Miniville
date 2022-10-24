using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boulangerie : GreenCards
{
    int activationCost;
    int costCards;

    string cardName;

    public Boulangerie()
    {
        this.activationCost = 4;
        this.costCards = 2;
        this.cardName = "Boulangerie";
    }

    public override void effectCards()
    {

    }
}
