using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Cards
{

    List<int> activationCost;
    public List<int> ActivationCost { get; set; }

    int costCards;
    public int CostCards { get; set; }

    string cardName;
    public string CardName { get; set; }
}
