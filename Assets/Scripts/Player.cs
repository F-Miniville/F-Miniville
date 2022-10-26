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

    private static List<int> number = new List<int>();
   

    public Boulangerie boulangerie = new Boulangerie(number, 2, "Boulangerie");
    public Cafe cafe = new Cafe(number, 2, "Cafe");
    public Centredaffaires centredaffaires = new Centredaffaires(number, 2, "centre d'affaires");
    public Chainedetele chainedetele = new Chainedetele(number, 2, "Chaine de tele");
    public Champsdeble champsdeble = new Champsdeble(number, 2, "Champs de blé");
    public Fabriquedemeuble fabriquedemeuble = new Fabriquedemeuble(number, 2, "Fabrique de meuble");
    public Ferme ferme = new Ferme(number, 2, "");
    public Forêt forêt = new Forêt(number, 2, "");
    public Fromagerie fromagerie = new Fromagerie(number, 2, "");
    public Marchedefruitsetlegumes marchedefruitsetlegumes = new Marchedefruitsetlegumes(number, 2, "");
    public Mine mine = new Mine(number, 2, "");
    public Restaurant restaurant = new Restaurant(number, 2, "");
    public Stade stade = new Stade(number, 2, "");
    public Superette superette = new Superette(number, 2, "");
    public Verger verger = new Verger(number, 2, "");

    public Centrecommercial centrecommercial = new Centrecommercial();
    public Gare gare = new Gare();
    public Parcdattraction parcdattraction = new Parcdattraction();
    public Tourradio tourradio = new Tourradio();


    public Dice firstDice = new Dice();
    public Dice secondDice = new Dice();
    public List<Dice> dices = new List<Dice>();
    

    public Player(string name)
    {
        dices.Add(firstDice);
        Gold = 0;
        Name = name;
        cards = new Dictionary<Cards, int>(){ {boulangerie, 1}, {cafe, 0 }, {centredaffaires, 0 }, { chainedetele, 0 }, {champsdeble, 1 }, {fabriquedemeuble, 0 }, {ferme , 0 }, {forêt, 0 }, { fromagerie, 0 }, {marchedefruitsetlegumes, 0 }, {mine, 0 }, {restaurant, 0 }, {stade, 0 }, {superette, 0 }, {verger, 0 } };
        etablissement = new Dictionary<Etablissement, bool>(){ { centrecommercial, false }, { gare, false }, { parcdattraction, false }, { tourradio, false } };
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
