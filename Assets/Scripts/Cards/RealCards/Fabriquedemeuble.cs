using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fabriquedemeuble : GreenCards
{
    List<int> activationCost;
    public override List<int> ActivationCost { get; set; }

    int costCards;
    public override int CostCards { get; set; }

    string cardName;
    public override string CardName { get; set; }

    public Fabriquedemeuble()
    {
        this.activationCost = new List<int>() { 8 };
        this.costCards = 3;
        this.cardName = "Fabrique de meuble";
    }

    public override void effectCards(Player p, List<Player> enemy)
    {

    }
}
