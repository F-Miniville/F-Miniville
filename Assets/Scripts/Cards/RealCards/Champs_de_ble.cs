using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Champs_de_ble : BlueCards
{
    int activationCost;
    int costCards;

    string cardName;

    public Champs_de_ble()
    {
        this.activationCost = 1;
        this.costCards = 1;
        this.cardName = "Champs de blé";
    }

    public override void effectCards()
    {

    }
}
