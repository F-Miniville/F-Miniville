using System.Collections;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using UnityEngine;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
<<<<<<< Updated upstream
    private Dictionary<Cards, int> cards = new Dictionary<Cards, int>();
    public Dictionary<Cards, int> Cards { get; set; }

    private Dictionary<Etablissement, bool> etablissement = new Dictionary<Etablissement, bool>();
    public Dictionary <Etablissement, bool> Etablissement { get; set; }

    protected int Gold;
    protected string Name;

    private static List<int> number = new List<int>();
   

    public Boulangerie boulangerie = new Boulangerie(number, 2, "Boulangerie");
    public Cafe cafe = new Cafe(number, 2, "Cafe");
    public Centredaffaires centredaffaires = new Centredaffaires(number, 2, "Centre d'affaires");
    public Chainedetele chainedetele = new Chainedetele(number, 2, "Chaine de tele");
    public Champsdeble champsdeble = new Champsdeble(number, 2, "Champs de blé");
    public Fabriquedemeuble fabriquedemeuble = new Fabriquedemeuble(number, 2, "Fabrique de meuble");
    public Ferme ferme = new Ferme(number, 2, "Ferme");
    public Forêt forêt = new Forêt(number, 2, "Forêt");
    public Fromagerie fromagerie = new Fromagerie(number, 2, "Fromagerie");
    public Marchedefruitsetlegumes marchedefruitsetlegumes = new Marchedefruitsetlegumes(number, 2, "Marche de fruits et de legumes");
    public Mine mine = new Mine(number, 2, "Mine");
    public Restaurant restaurant = new Restaurant(number, 2, "Restaurant");
    public Stade stade = new Stade(number, 2, "Stade");
    public Superette superette = new Superette(number, 2, "Superette");
    public Verger verger = new Verger(number, 2, "Verger");

    public Centrecommercial centrecommercial = new Centrecommercial();
    public Gare gare = new Gare();
    public Parcdattraction parcdattraction = new Parcdattraction();
    public Tourradio tourradio = new Tourradio();


    public Dice firstDice = new Dice();
    public Dice secondDice = new Dice();
    private List<Dice> dices = new List<Dice>();

    public Player(string name)
    {
        Gold = 0;
        Name = name;
        cards = new Dictionary<Cards, int>(){ {boulangerie, 1}, {cafe, 0 }, {centredaffaires, 0 }, { chainedetele, 0 }, {champsdeble, 1 }, {fabriquedemeuble, 0 }, {ferme , 0 }, {forêt, 0 }, { fromagerie, 0 }, {marchedefruitsetlegumes, 0 }, {mine, 0 }, {restaurant, 0 }, {stade, 0 }, {superette, 0 }, {verger, 0 } };
        etablissement = new Dictionary<Etablissement, bool>(){ { centrecommercial, false }, { gare, false }, { parcdattraction, false }, { tourradio, false } };
    }

    private void Awake()
    {
        dices.Add(firstDice);
=======

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
>>>>>>> Stashed changes
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

<<<<<<< Updated upstream
    public void AddCard(Cards C)
    {
        cards[C] += 1;
    }

    public void AddEtablissement(Etablissement E)
    {
        etablissement[E] = true;
    }

    public List<Dice> Dices
    {
        get { return dices; }
        set { dices = value; }
=======
    public List<Cards> BlueCards()
    {
        return blueCards;
>>>>>>> Stashed changes
    }
}
