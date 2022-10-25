using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PurpleCards : Cards
{
    List<int> activationCost;
    public List<int> ActivationCostList { get; }

    readonly int costCards;

    readonly string cardName;
    public PurpleCards()
    {

    }
    public abstract void effectCards();
}
