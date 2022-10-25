using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chainedetele : PurpleCards
{
    List<int> activationCost;
    public override List<int> ActivationCost { get; set; }

    int costCards;
    public override int CostCards { get; set; }

    string cardName;
    public override string CardName { get; set; }

    public Chainedetele()
    {
        this.activationCost = new List<int>() { 6 };
        this.costCards = 7;
        this.cardName = "Chaine de tele";
    }

    public override void effectCards(Player p, List<Player> enemy)
    {

    }
}
