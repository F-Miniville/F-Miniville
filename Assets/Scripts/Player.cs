using System.Collections;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using UnityEngine;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    private Dictionary<Cards, int> cards = new Dictionary<Cards, int>();
    public Dictionary<Cards, int> Cards { get; set; }

    private Dictionary<Etablissement, bool> etablissement = new Dictionary<Etablissement, bool>();
    public Dictionary <Etablissement, bool> Etablissement { get; set; }

    protected int Gold;
    protected string Name;

    public Boulangerie boulangerie = new Boulangerie();
    public Cafe cafe = new Cafe();
    public Centredaffaires centredaffaires = new Centredaffaires();
    public Chainedetele chainedetele = new Chainedetele();
    public Champsdeble champsdeble = new Champsdeble();
    public Fabriquedemeuble fabriquedemeuble = new Fabriquedemeuble();
    public Ferme ferme = new Ferme();
    public Forêt forêt = new Forêt();
    public Fromagerie fromagerie = new Fromagerie();
    public Marchedefruitsetlegumes marchedefruitsetlegumes = new Marchedefruitsetlegumes();
    public Mine mine = new Mine();
    public Restaurant restaurant = new Restaurant();
    public Stade stade = new Stade();
    public Superette superette = new Superette();
    public Verger verger = new Verger();

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
    }
}
