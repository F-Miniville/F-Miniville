using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Champsdeble : BlueCards
{
    List<int> activationCost;
    int costCards;

    string cardName;

    public Champsdeble()
    {
        this.activationCost = new List<int>() { 1 };
        this.costCards = 1;
        this.cardName = "Champs de blé";
    }

    public override void effectCards()
    {

    }
}
