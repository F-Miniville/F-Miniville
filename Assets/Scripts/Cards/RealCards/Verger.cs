using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Verger : BlueCards
{
    List<int> activationCost;
    public override List<int> ActivationCost { get; set; }

    int costCards;
    public override int CostCards { get; set; }

    string cardName;
    public override string CardName { get; set; }

    public Verger()
    {
        this.activationCost = new List<int>() { 10 };
        this.costCards = 3;
        this.cardName = "Verger";
    }

    public override void effectCards(Player p, List<Player> enemy)
    {

    }
}
