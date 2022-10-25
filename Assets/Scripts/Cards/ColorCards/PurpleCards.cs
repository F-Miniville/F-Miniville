using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PurpleCards : Cards
{
    List<int> activationCost;

    int costCards;

    string cardName;
    public PurpleCards()
    {

    }
    public abstract void effectCards(Player p, List<Player> enemy);
}
