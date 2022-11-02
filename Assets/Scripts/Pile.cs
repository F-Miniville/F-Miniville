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
        int _PlayerGold = Game.instance.playerTurn.GetComponent<Player>().Gold;
        int _CostOfCardsInPile = cardsInPile[0].GetComponent<Cards>().costCards;

        if (Game.instance._Boutique && (_PlayerGold >= _CostOfCardsInPile))
        {
            Game.instance.playerTurn.GetComponent<Player>().Gold -= _CostOfCardsInPile;

            GameObject card = GetCardsFromPile(cardsInPile[^1]);

            Game.instance.playerTurn.GetComponent<Player>().cardsObject.Add(card);
            
            Debug.Log(Game.instance.playerTurn.name + " à acheter " + card.name);

            Game.instance._Boutique = false;
        }
    }

}
