using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Superette : GreenCards
{
    List<int> activationCost;
    public override List<int> ActivationCost { get; set; }

    int costCards;
    public override int CostCards { get; set; }

    string cardName;
    public override string CardName { get; set; }

    public Superette()
    {
        this.activationCost = new List<int>() { 4 };
        this.costCards = 2;
        this.cardName = "Superette";
    }

    public override void effectCards(Player p, List<Player> enemy)
    {

    }
}
