using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Champsdeble : BlueCards
{
    List<int> activationCost;
    public new List<int> ActivationCost { get; set; }

    int costCards;
    public int CostCards { get; set; }

    string cardName;
    public string CardName { get; set; }

    public Champsdeble(List<int> activationCost, int costCards, string cardName) : base(activationCost, costCards, cardName)
    {
        this.activationCost = new List<int>() { 1 };
        this.costCards = 1;
        this.cardName = "Champs de blé";
    }

    public override void effectCards(Player p, List<Player> enemy)
    {

    }
}
