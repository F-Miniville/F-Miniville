using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GreenCards : Cards
{
    List<int> activationCost;
    public List<int> ActivationCost { get; set; }

    int costCards;
    public GreenCards(List<int> activationCost, int costCards, string cardName) : base(activationCost, costCards, cardName)
    {

    }
    public abstract void effectCards(Player p, List<Player> enemy);
}
