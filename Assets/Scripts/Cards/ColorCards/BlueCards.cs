using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BlueCards : Cards
{
    List<int> activationCost;
    public List<int> ActivationCostList { get; }
    readonly int costCards;

    readonly string cardName;
    public BlueCards()
    {

    }
    public abstract void effectCards();
}
