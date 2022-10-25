using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forêt : BlueCards
{
    List<int> activationCost;
    public new List<int> ActivationCost { get; set; }

    int costCards;
    public int CostCards { get; set; }

    string cardName;
    public override string CardName { get; set; }
    public Forêt(List<int> activationCost, int costCards, string cardName) : base(activationCost, costCards, cardName)
    {
        this.activationCost = new List<int>() { 5 };
        this.costCards = 3;
        this.cardName = "Forêt";
    }

    public override void effectCards(Player p, List<Player> enemy)
    {

    }
}
