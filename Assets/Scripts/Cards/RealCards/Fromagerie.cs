using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fromagerie : GreenCards
{
    List<int> activationCost;
    public List<int> ActivationCost { get; set; }

    int costCards;
    public int CostCards { get; set; }

    string cardName;
    public string CardName { get; set; }
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
