using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boulangerie : GreenCards
{
    List<int> activationCost;
    public new List<int> ActivationCost { get; set; }

    int costCards;
    public int CostCards { get; set; }

    string cardName;
    public string CardName { get; set; }

    public Boulangerie(List<int> activationCost, int costCards, string cardName) : base(activationCost, costCards, cardName)
    {
        this.activationCost = new List<int>() { 2, 3};
        this.costCards = 1;
        this.cardName = "Boulangerie";
    }

    public override void effectCards(Player p, List<Player> enemy)
    {

    }
}
