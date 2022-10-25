using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GreenCards : Cards
{
    List<int> activationCost;

    int costCards;

    string cardName;
    public GreenCards()
    {

    }
    public abstract void effectCards(Player p, List<Player> enemy);
}
