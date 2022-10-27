using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fabriquedemeuble : GreenCards
{
    List<int> activationCost;
    public new List<int> ActivationCost { get; set; }

    int costCards;
    public int CostCards { get; set; }

    string cardName;
    public string CardName { get; set; }

    public Fabriquedemeuble(List<int> activationCost, int costCards, string cardName) : base(activationCost, costCards, cardName)
    {
        this.activationCost = new List<int>() { 8 };
        this.costCards = 3;
    }

    public override void effectCards(Player p, List<Player> enemy, int result)
    {

    }
}
