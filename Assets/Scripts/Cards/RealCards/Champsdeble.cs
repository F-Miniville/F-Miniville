using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Champsdeble : BlueCards
{
    List<int> activationCost;
    public override List<int> ActivationCost { get; set; }

    int costCards;
    public override int CostCards { get; set; }

    string cardName;
    public override string CardName { get; set; }

    public Champsdeble()
    {
        this.activationCost = new List<int>() { 1 };
        this.costCards = 1;
        this.cardName = "Champs de blé";
    }

    public override void effectCards(Player p, List<Player> enemy)
    {

    }
}
