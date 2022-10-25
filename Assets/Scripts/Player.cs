using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    protected Dictionary<Cards, int> Cards = new Dictionary<Cards, int>();
    protected Dictionary<Etablissement, bool> Etablissement = new Dictionary<Etablissement, bool>();
    protected int Gold;
    protected string Name;

    private Boulangerie boulangerie = new Boulangerie();
    private Cafe cafe = new Cafe();
    private Centredaffaires centredaffaires = new Centredaffaires();
    private Chainedetele chainedetele = new Chainedetele();
    private Champsdeble champsdeble = new Champsdeble();
    private Fabriquedemeuble fabriquedemeuble = new Fabriquedemeuble();
    private Ferme ferme = new Ferme();
    private Forêt forêt = new Forêt();
    private Fromagerie fromagerie = new Fromagerie();
    private Marchedefruitsetlegumes marchedefruitsetlegumes = new Marchedefruitsetlegumes();
    private Mine mine = new Mine();
    private Restaurant restaurant = new Restaurant();
    private Stade stade = new Stade();
    private Superette superette = new Superette();
    private Verger verger = new Verger();

    private Centrecommercial centrecommercial = new Centrecommercial();
    private Gare gare = new Gare();
    private Parcdattraction parcdattraction = new Parcdattraction();
    private Tourradio tourradio = new Tourradio();

    public Player(string name)
    {
        Gold = 0;
        Name = name;
        Cards = new Dictionary<Cards, int>() { { boulangerie, 1 }, { cafe, 0 }, { centredaffaires, 0 }, { chainedetele, 0 }, { champsdeble, 1 }, { fabriquedemeuble, 0 }, { ferme, 0 }, { forêt, 0 }, { fromagerie, 0 }, { marchedefruitsetlegumes, 0 }, { mine, 0 }, { restaurant, 0 }, { stade, 0 }, { superette, 0 }, { verger, 0 } };
        Etablissement = new Dictionary<Etablissement, bool>() { { centrecommercial, false }, { gare, false }, { parcdattraction, false }, { tourradio, false } };
        Cards[champsdeble] += 1;
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
