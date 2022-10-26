using System.Collections;
using System.Collections.Generic;
using System.Linq;
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





    public void Awake()
    {
        boulangerieScript = boulangerie.GetComponent<Boulangerie>();
        champsdebleScript = champsdeble.GetComponent<Champsdeble>();

        cards = new List<Cards>() { champsdebleScript, boulangerieScript };
        etablissements = new List<Etablissement>();

        foreach(BlueCards blueCards in cards)
        {
            ReadCards(blueCards);
            Debug.Log("Fin BlueCards");

        }
    }

    public void ReadCards(Cards card)
    {
        Debug.Log(card.cardName);
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
