using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class RedCards : Cards
{
    List<int> activationCost;
    public List<int> ActivationCost { get; set; }

    int costCards;

    string cardName;
    public RedCards(List<int> activationCost, int costCards, string cardName) : base(activationCost, costCards, cardName)
    {
        this.activationCost = activationCost;
        this.costCards = costCards;
        this.cardName = cardName;
    }
    public abstract void effectCards(Player p, List<Player> enemy);
}
