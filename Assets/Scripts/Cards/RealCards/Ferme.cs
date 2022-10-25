using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ferme : BlueCards
{
    List<int> activationCost;
    public override List<int> ActivationCost { get; set; }

    int costCards;
    public override int CostCards { get; set; }

    string cardName;
    public override string CardName { get; set; }

    public Ferme()
    {
        this.activationCost = new List<int>() { 2 };
        this.costCards = 1;
        this.cardName = "Ferme";
    }

    public override void effectCards(Player p, List<Player> enemy)
    {

    }
}
