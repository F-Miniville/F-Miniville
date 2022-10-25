using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mine : BlueCards
{
    List<int> activationCost;
    public override List<int> ActivationCost { get; set; }

    int costCards;
    public override int CostCards { get; set; }

    string cardName;
    public override string CardName { get; set; }

    public Mine()
    {
        this.activationCost = new List<int>() { 9 };
        this.costCards = 6;
        this.cardName = "Mine";
    }

    public override void effectCards(Player p, List<Player> enemy)
    {

    }
}
