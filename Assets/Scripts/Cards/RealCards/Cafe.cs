using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cafe : RedCards
{
    List<int> activationCost;
    public List<int> ActivationCost { get; set; }

    int costCards;
    public int CostCards { get; set; }

    string cardName;
    public string CardName { get; set; }

    public Cafe()
    {
        this.activationCost = new List<int>() { 3 };
        this.costCards = 2;
        this.cardName = "Cafe";
    }

    public override void effectCards(Player p, List<Player> enemy)
    {

    }
}
