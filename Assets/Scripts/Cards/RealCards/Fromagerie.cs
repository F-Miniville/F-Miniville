using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fromagerie : GreenCards
{
    List<int> activationCost;
    int costCards;

    string cardName;

    public Fromagerie()
    {
        this.activationCost = new List<int>() { 7 };
        this.costCards = 5;
        this.cardName = "Fromagerie";
    }

    public override void effectCards()
    {

    }
}
