using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Verger : BlueCards
{
    List<int> activationCost;
    public List<int> ActivationCost { get; set; }

    int costCards;
    public int CostCards { get; set; }

    string cardName;
    public string CardName { get; set; }

    public Verger()
    {
        this.activationCost = new List<int>() { 10 };
        this.costCards = 3;
        this.cardName = "Verger";
    }

    public override void effectCards(Player p, List<Player> enemy)
    {

    }
}
