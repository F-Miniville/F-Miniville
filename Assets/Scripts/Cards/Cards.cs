using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Cards
{

    List<int> activationCost;

    int costCards;

    public string cardName;

    public Cards(List<int> activationCost, int costCards, string cardName)
    {
        this.cardName = cardName;
    }
}
