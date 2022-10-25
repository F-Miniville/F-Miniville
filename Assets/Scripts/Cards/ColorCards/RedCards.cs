using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class RedCards : Cards
{
    List<int> activationCost;
    public virtual List<int> ActivationCost { get; set; }

    int costCards;

    string cardName;
    public RedCards()
    {

    }
    public abstract void effectCards(Player p, List<Player> enemy);
}
