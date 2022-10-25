using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Centredaffaires : PurpleCards
{
    List<int> activationCost;
    public new List<int> ActivationCost { get; set; }

    int costCards;
    public int CostCards { get; set; }

    string cardName;
    public override string CardName { get; set; }
    public Centredaffaires(List<int> activationCost, int costCards, string cardName) : base(activationCost, costCards, cardName)
    {
        this.activationCost = new List<int>() { 6 };
        this.costCards = 8;
        this.cardName = "Centre d'affaires";
    }

    public override void effectCards(Player p, List<Player> enemy)
    {

    }
}
