using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marchedefruitsetlegumes : GreenCards
{
    List<int> activationCost;
    public new List<int> ActivationCost { get; set; }

    int costCards;
    public int CostCards { get; set; }

    string cardName;
    public string CardName { get; set; }

    public Marchedefruitsetlegumes(List<int> activationCost, int costCards, string cardName) : base(activationCost, costCards, cardName)
    {
        this.activationCost = new List<int>() { 10, 11 };
        this.costCards = 2;
    }

    public override void effectCards(Player p, List<Player> enemy)
    {

    }
}
