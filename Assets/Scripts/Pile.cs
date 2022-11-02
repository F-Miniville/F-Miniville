using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pile : MonoBehaviour
{
    public List<GameObject> cardsInPile;
    public int costOfCardsInPile;

    public void AddCardToPile(List<GameObject> newCards)
    {
        foreach(GameObject card in newCards)
        {
            var cardAdd = Instantiate(card);
            cardAdd.transform.position = new Vector3(1000, 1000, 0);
            cardsInPile.Add(cardAdd);
        }
    }

    public GameObject GetCardsFromPile(GameObject cardPlayerWant)
    {
        GameObject card = null;

        if((cardsInPile.Count != 0) && (cardPlayerWant == cardsInPile[^1]))
        {
            card = cardsInPile[^1];
            cardsInPile.Remove(cardsInPile[^1]);
        }

        return card;
    }

    void OnMouseDown()
    {
        int _PlayerGold = Game.instance.playerTurn.GetComponent<Player>().Gold;

        if (Game.instance._Boutique && (_PlayerGold >= costOfCardsInPile))
        {
            Game.instance.playerTurn.GetComponent<Player>().Gold -= costOfCardsInPile;

            GameObject card = GetCardsFromPile(cardsInPile[^1]);

            Game.instance.playerTurn.GetComponent<Player>().cardsObject.Add(card);

            if (cardsInPile.Count <= 0)
            {
                this.gameObject.SetActive(false);
                Game.instance._PileList.Remove(this.gameObject);
                this.gameObject.GetComponent<infoCard>().WhenDestroy();
            }

            Game.instance.RefreshScreen();
            
            Debug.Log(Game.instance.playerTurn.name + " à acheter " + card.name);

            Game.instance._Boutique = false;

        }
    }

    public void IAAchatPile()
    {
        int _PlayerGold = Game.instance.playerTurn.GetComponent<Player>().Gold;

        if (Game.instance._Boutique && (_PlayerGold >= costOfCardsInPile))
        {
            Game.instance.playerTurn.GetComponent<Player>().Gold -= costOfCardsInPile;

            GameObject card = GetCardsFromPile(cardsInPile[^1]);

            Game.instance.playerTurn.GetComponent<Player>().cardsObject.Add(card);

            if (cardsInPile.Count <= 0)
            {
                this.gameObject.SetActive(false);
                Game.instance._PileList.Remove(this.gameObject);
                this.gameObject.GetComponent<infoCard>().WhenDestroy();
            }

            Game.instance.RefreshScreen();

            Debug.Log(Game.instance.playerTurn.name + " à acheter " + card.name);

            Game.instance._Boutique = false;

        }
    }

}
