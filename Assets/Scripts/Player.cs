using System.Collections;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using UnityEngine;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    public int Gold;


    public List<Etablissement> etablissements;

    public List<Cards> cards;
    public List<GameObject> cardsObject;


    [SerializeField] GameObject boulangerie;
    [SerializeField] GameObject champsdeble;


    public List<Cards> blueCards;
    public List<Cards> greenCards;
    public List<Cards> redCards;
    public List<Cards> purpleCards;

    public int _intPlayer;



    public void Awake()
    {
        Gold = 0;

        

        cardsObject = new List<GameObject>() { boulangerie, champsdeble};
        foreach(GameObject card in cardsObject)
        {
            Cards _cards = card.GetComponent<Cards>();
            cards.Add(_cards);
        }

        etablissements = new List<Etablissement>();

        ClasifiedCards();

        Debug.Log("Fin Awake Player");
    }


    public void ClasifiedCards()
    {
        blueCards = new List<Cards>();
        greenCards = new List<Cards>();
        redCards = new List<Cards>();
        purpleCards = new List<Cards>();

        foreach (Cards card in cards)
        {
            if (card.color == "Blue")
            {
                blueCards.Add(card);
            }
            else if (card.color == "Green")
            {
                greenCards.Add(card);
            }
            else if (card.color == "Red")
            {
                redCards.Add(card);
            }
            else if (card.color == "Purple")
            {
                purpleCards.Add(card);
            }
        }
    }
    public void AddCards(GameObject card)
    {
        Cards _cards = card.GetComponent<Cards>();
        cards.Add(_cards);
        Debug.Log("Add : " + _cards.name + " to Cards");
    }

    public void spendGold(int i)
    {
        Gold -= i;
        if (Gold < 0)
        {
            Gold = 0;
        }
    }
    public void earnGold(int i)
    {
        if(i >= 0)
        {
            Gold += i;
        }
        else
        {
            Debug.Log("int i est négatif");
        }
    }
}
