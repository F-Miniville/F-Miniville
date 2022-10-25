using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Centredaffaires : PurpleCards
{
    List<int> activationCost;
    public List<int> ActivationCost { get; set; }

    int costCards;
    public int CostCards { get; set; }

    string cardName;
    public string CardName { get; set; }
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
