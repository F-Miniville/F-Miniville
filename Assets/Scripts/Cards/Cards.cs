using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Cards
{

    List<int> activationCost;

    int costCards;

    string cardName;
    public virtual string CardName { get; set; }

    public Cards(List<int> activationCost, int costCards, string cardName)
    {

    }
}
