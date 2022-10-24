using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Centredaffaires : PurpleCards
{
    List<int> activationCost;
    int costCards;

    string cardName;

    public Centredaffaires()
    {
        this.activationCost = new List<int>() { 6 };
        this.costCards = 8;
        this.cardName = "Centre d'affaires";
    }

    public override void effectCards()
    {

    }
}
