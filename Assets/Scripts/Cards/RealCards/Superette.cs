using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Superette : GreenCards
{
    List<int> activationCost;
    public new List<int> ActivationCost { get; set; }

    int costCards;
    public int CostCards { get; set; }

    string cardName;
    public override string CardName { get; set; }

    public Superette(List<int> activationCost, int costCards, string cardName) : base(activationCost, costCards, cardName)
    {
        this.activationCost = new List<int>() { 4 };
        this.costCards = 2;
        this.cardName = "Superette";
    }

    public override void effectCards(Player p, List<Player> enemy)
    {

    }
}
