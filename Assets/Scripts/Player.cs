using System.Collections;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using UnityEngine;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    [SerializeField] int gold;
    public int Gold { get; set; }


    public List<Etablissement> etablissements;

    public List<Cards> cards;


    [SerializeField] GameObject boulangerie;
    [SerializeField] GameObject champsdeble;

    Boulangerie boulangerieScript;
    Champsdeble champsdebleScript;

    public List<Cards> blueCards;
    public List<Cards> greenCards;
    public List<Cards> redCards;
    public List<Cards> purpleCards;



    public void Awake()
    {
        Gold = 0;

        boulangerieScript = boulangerie.GetComponent<Boulangerie>();
        champsdebleScript = champsdeble.GetComponent<Champsdeble>();

        cards = new List<Cards>() { champsdebleScript, boulangerieScript };
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
    public void AddCards(Cards card)
    {
        cards.Add(card);
        Debug.Log("Add : " + card + " to Cards");
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
        Gold += i;
    }
}
