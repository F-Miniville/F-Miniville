using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Cards : MonoBehaviour
{

    public List<int> activationCost;

    public int costCards;

    protected string cardName;

    public string color;

    public Cards(List<int> activationCost, int costCards, string cardName, string color)
    {
        this.cardName = cardName;
        this.color = color;
        this.activationCost = activationCost;
        this.costCards = costCards;
    }

    public virtual void effectCards(Player p, List<Player> enemy, int result)
    {
        Debug.Log("Cards effectCards");
    }
}
