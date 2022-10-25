using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GreenCards : Cards
{
    List<int> activationCost;
    public List<int> ActivationCost { get; set; }

    int costCards;

    string cardName;
    public override string CardName { get; set; }
    public GreenCards(List<int> activationCost, int costCards, string cardName) : base(activationCost, costCards, cardName)
    {
        this.cardName = cardName;
    }
    public abstract void effectCards(Player p, List<Player> enemy);
}
