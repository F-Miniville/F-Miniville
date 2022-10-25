using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class RedCards : Cards
{
    List<int> activationCost;
    public List<int> ActivationCostList { get; }
    readonly int costCards;

    readonly string cardName;
    public RedCards()
    {

    }
    public abstract void effectCards(Player p, List<Player> enemy);
}
