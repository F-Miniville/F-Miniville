using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pile
{
    public List<GameObject> cardsInPile;

    public void AddCardToPile(List<GameObject> newCards)
    {
        foreach(GameObject card in newCards)
        {
            cardsInPile.Add(card);
        }
    }
    
}
