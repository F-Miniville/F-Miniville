using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forêt : BlueCards
{
    List<int> activationCost;
    public override List<int> ActivationCost { get; set; }

    int costCards;
    public override int CostCards { get; set; }

    string cardName;
    public override string CardName { get; set; }
    public Forêt()
    {
        this.activationCost = new List<int>() { 5 };
        this.costCards = 3;
        this.cardName = "Forêt";
    }

    public override void effectCards(Player p, List<Player> enemy)
    {

    }
}
