using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chainedetele : PurpleCards
{
    readonly List<int> activationCost;
    readonly int costCards;

    readonly string cardName;

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
