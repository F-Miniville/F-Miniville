using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stade : BlueCards
{
    List<int> activationCost;
    public new List<int> ActivationCost { get; set; }

    int costCards;
    public int CostCards { get; set; }

    string cardName;
    public override string CardName { get; set; }

    public Stade(List<int> activationCost, int costCards, string cardName) : base(activationCost, costCards, cardName)
    {
        this.activationCost = new List<int>() { 6 };
        this.costCards = 6;
        this.cardName = "Stade";
    }

    public override void effectCards(Player p, List<Player> enemy)
    {

    }
}
