using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ferme : BlueCards
{
    int activationCost;
    int costCards;

    string cardName;

    public Ferme()
    {
        this.activationCost = 1;
        this.costCards = 2;
        this.cardName = "Ferme";
    }

    public override void effectCards()
    {

    }
}
