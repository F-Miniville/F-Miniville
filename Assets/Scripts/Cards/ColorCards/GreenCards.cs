using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GreenCards : Cards
{
    List<int> activationCost;
    public List<int> ActivationCostList { get; }
    readonly int costCards;

    readonly string cardName;
    public GreenCards()
    {

    }
    public abstract void effectCards(Player p, List<Player> enemy);
}
