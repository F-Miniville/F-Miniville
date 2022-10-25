using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Cards
{

    List<int> activationCost;

    int costCards;

    string cardName;

    public Cards(List<int> activationCost, int costCards, string cardName)
    {
        this.activationCost = activationCost;
        this.costCards = costCards;
        this.cardName = cardName;
    }
}
