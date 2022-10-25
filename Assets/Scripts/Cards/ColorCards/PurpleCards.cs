using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PurpleCards : Cards
{
    List<int> activationCost;
    public override List<int> ActivationCost { get; set; }

    int costCards;
    public override int CostCards { get; set; }

    string cardName;
    public override string CardName { get; set; }
    public PurpleCards()
    {

    }
    public abstract void effectCards(Player p, List<Player> enemy);
}
