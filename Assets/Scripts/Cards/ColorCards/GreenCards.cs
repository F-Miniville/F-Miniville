using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GreenCards : Cards
{
    List<int> activationCost;
    public List<int> ActivationCost { get; set; }

    int costCards;

    public GreenCards(List<int> activationCost, int costCards, string cardName, string color) : base(activationCost, costCards, cardName, color)
    {

    }
    public abstract void effectCards(Player p, List<Player> enemy);
}
