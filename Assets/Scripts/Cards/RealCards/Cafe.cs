using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cafe : RedCards
{
    List<int> activationCost;
    public override List<int> ActivationCost { get; set; }

    int costCards;
    public override int CostCards { get; set; }

    string cardName;
    public override string CardName { get; set; }

    public Cafe()
    {
        this.activationCost = new List<int>() { 3 };
        this.costCards = 2;
        this.cardName = "Cafe";
    }

    public override void effectCards(Player p, List<Player> enemy)
    {

    }
}
