using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restaurant : RedCards
{
    List<int> activationCost;
    public new List<int> ActivationCost { get; set; }

    int costCards;
    public int CostCards { get; set; }

    string cardName;
    public string CardName { get; set; }

    public Restaurant(List<int> activationCost, int costCards, string cardName) : base(activationCost, costCards, cardName)
    {
        this.activationCost = new List<int>() { 9, 10 };
        this.costCards = 3;
        this.cardName = "Restaurant";
    }

    public override void effectCards(Player p, List<Player> enemy, int result)
    {

    }
}
