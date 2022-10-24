using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marchedefruitsetlegumes : GreenCards
{
    readonly List<int> activationCost;
    readonly int costCards;

    readonly string cardName;

    public Marchedefruitsetlegumes()
    {
        this.activationCost = new List<int>() { 10, 11 };
        this.costCards = 2;
        this.cardName = "Marche de fruits et legumes";
    }

    public override void effectCards()
    {

    }
}
