using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fabriquedemeuble : GreenCards
{
    List<int> activationCost;
    int costCards;

    string cardName;

    public Fabriquedemeuble()
    {
        this.activationCost = new List<int>() { 8 };
        this.costCards = 3;
        this.cardName = "Fabrique de meuble";
    }

    public override void effectCards()
    {

    }
}
