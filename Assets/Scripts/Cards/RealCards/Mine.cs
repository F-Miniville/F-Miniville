using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mine : BlueCards
{
    List<int> activationCost;
    public new List<int> ActivationCost { get; set; }

    int costCards;
    public int CostCards { get; set; }

    string cardName;
    public string CardName { get; set; }

    public Mine(List<int> activationCost, int costCards, string cardName) : base(activationCost, costCards, cardName)
    {
        this.activationCost = new List<int>() { 9 };
        this.costCards = 6;
    }

    public override void effectCards(Player p, List<Player> enemy)
    {

    }
}
