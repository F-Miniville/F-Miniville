using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fromagerie : GreenCards
{
    readonly List<int> activationCost;
    readonly int costCards;

    readonly string cardName;

    public Fromagerie()
    {
        this.activationCost = new List<int>() { 7 };
        this.costCards = 5;
        this.cardName = "Fromagerie";
    }

    public override void effectCards(Player p, List<Player> enemy)
    {

    }
}
