using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Cards
{

    public List<int> activationCost;

    public int costCards;

    public string cardName;

    public Cards(List<int> activationCost, int costCards, string cardName)
    {
        this.cardName = cardName;
<<<<<<< Updated upstream
=======
        this.color = color;
        this.activationCost = activationCost;
        this.costCards = costCards;
    }

    public virtual void effectCards(Player p, List<Player> enemy, int result)
    {
        Debug.Log("Cards effectCards");
>>>>>>> Stashed changes
    }
}
