using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Centredaffaires : PurpleCards
{
    List<int> activationCost;
    public override List<int> ActivationCost { get; set; }

    int costCards;
    public override int CostCards { get; set; }

    string cardName;
    public override string CardName { get; set; }
    public Centredaffaires()
    {
        this.activationCost = new List<int>() { 6 };
        this.costCards = 8;
        this.cardName = "Centre d'affaires";
    }

    public override void effectCards(Player p, List<Player> enemy)
    {

    }
}
