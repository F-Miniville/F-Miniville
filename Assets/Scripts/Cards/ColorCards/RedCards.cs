using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class RedCards : Cards
{
    public RedCards(List<int> activationCost, int costCards, string cardName, string color) : base(activationCost, costCards, cardName, color)
    {

    }
}
