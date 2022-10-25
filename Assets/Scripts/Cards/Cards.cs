using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Cards
{

    List<int> activationCost;
    public abstract List<int> ActivationCost { get; set; }

    int costCards;
    public abstract int CostCards { get; set; }

    string cardName;
    public abstract string CardName { get; set; }
}
