using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pile : MonoBehaviour
{
    public List<GameObject> cardsInPile;

    public void AddCardToPile(List<GameObject> newCards)
    {
        foreach(GameObject card in newCards)
        {
            cardsInPile.Add(card);
        }
    }

    public GameObject GetCardsFromPile(GameObject cardPlayerWant)
    {
        GameObject card = null;

        foreach(GameObject cards in cardsInPile)
        {
            if(cardPlayerWant == cards)
            {
                card = cards;
                cardsInPile.Remove(cards);
            }
        }

        return card;
    }

    void OnMouseDown()
    {
        if (Game.instance._Boutique && ( Game.instance.playerTurn.GetComponent<Player>().Gold >= cardsInPile[0].GetComponent<Cards>().costCards ))
        {
            Debug.Log("Click on Pile");
        }
    }

}
