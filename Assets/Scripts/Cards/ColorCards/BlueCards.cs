using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BlueCards : Cards
{
    List<int> activationCost;

    int costCards;

    string cardName;
    public BlueCards()
    {

    }
    public abstract void effectCards(Player p, List<Player> enemy);
}
