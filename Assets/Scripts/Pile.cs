using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pile : MonoBehaviour
{
    protected Dictionary<Cards, int> cards = new Dictionary<Cards, int>();

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

    public Pile()
    {
        cards = new Dictionary<Cards, int>() { { boulangerie, 0 }, { cafe, 6 }, { centredaffaires, 4 }, { chainedetele, 4 }, { champsdeble, 0 }, { fabriquedemeuble, 6 }, { ferme, 6 }, { forêt, 6 }, { fromagerie, 6 }, { marchedefruitsetlegumes, 6 }, { mine, 6 }, { restaurant, 6 }, { stade, 4 }, { superette, 6 }, { verger, 6 } };
    }
}
