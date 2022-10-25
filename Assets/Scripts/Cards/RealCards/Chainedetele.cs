using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chainedetele : PurpleCards
{
    List<int> activationCost;
    public new List<int> ActivationCost { get; set; }

    int costCards;
    public int CostCards { get; set; }

    string cardName;
    public string CardName { get; set; }

    public Chainedetele(List<int> activationCost, int costCards, string cardName) : base(activationCost, costCards, cardName)
    {
        this.activationCost = new List<int>() { 6 };
        this.costCards = 7;
        this.cardName = "Chaine de tele";
    }

    public override void effectCards(Player p, List<Player> enemy)
    {

    }
}
