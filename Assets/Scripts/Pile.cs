using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pile : MonoBehaviour
{
    protected Dictionary<Cards, int> cards = new Dictionary<Cards, int>();

    private static List<int> number = new List<int>();

    public Boulangerie boulangerie = new Boulangerie(number, 2, "");
    public Cafe cafe = new Cafe(number, 2, "");
    public Centredaffaires centredaffaires = new Centredaffaires(number, 2, "");
    public Chainedetele chainedetele = new Chainedetele(number, 2, "");
    public Champsdeble champsdeble = new Champsdeble(number, 2, "");
    public Fabriquedemeuble fabriquedemeuble = new Fabriquedemeuble(number, 2, "");
    public Ferme ferme = new Ferme(number, 2, "");
    public Forêt forêt = new Forêt(number, 2, "");
    public Fromagerie fromagerie = new Fromagerie(number, 2, "");
    public Marchedefruitsetlegumes marchedefruitsetlegumes = new Marchedefruitsetlegumes(number, 2, "");
    public Mine mine = new Mine(number, 2, "");
    public Restaurant restaurant = new Restaurant(number, 2, "");
    public Stade stade = new Stade(number, 2, "");
    public Superette superette = new Superette(number, 2, "");
    public Verger verger = new Verger(number, 2, "");

    public Pile()
    {
        cards = new Dictionary<Cards, int>() { { boulangerie, 0 }, { cafe, 6 }, { centredaffaires, 4 }, { chainedetele, 4 }, { champsdeble, 0 }, { fabriquedemeuble, 6 }, { ferme, 6 }, { forêt, 6 }, { fromagerie, 6 }, { marchedefruitsetlegumes, 6 }, { mine, 6 }, { restaurant, 6 }, { stade, 4 }, { superette, 6 }, { verger, 6 } };
    }
}
