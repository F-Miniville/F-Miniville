using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forêt : BlueCards
{
    List<int> activationCost;
    public List<int> ActivationCost { get; set; }

    int costCards;
    public int CostCards { get; set; }

    string cardName;
    public string CardName { get; set; }
    public Forêt()
    {
        this.activationCost = new List<int>() { 5 };
        this.costCards = 3;
        this.cardName = "Forêt";
    }

    public override void effectCards(Player p, List<Player> enemy)
    {

    }
}
