using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restaurant : RedCards
{
    List<int> activationCost;
    int costCards;

    string cardName;

    public Restaurant()
    {
        this.activationCost = new List<int>() { 9, 10 };
        this.costCards = 3;
        this.cardName = "Restaurant";
    }

    public override void effectCards()
    {

    }
}
