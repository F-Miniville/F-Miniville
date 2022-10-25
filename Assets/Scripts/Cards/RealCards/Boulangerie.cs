using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boulangerie : GreenCards
{
    readonly List<int> activationCost;
    readonly int costCards;

    readonly string cardName;

    public Boulangerie()
    {
        this.activationCost = new List<int>() { 2, 3};
        this.costCards = 1;
        this.cardName = "Boulangerie";
    }

    public override void effectCards(Player p, List<Player> enemy)
    {

    }
}
