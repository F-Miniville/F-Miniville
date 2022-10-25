using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    protected Dictionary<Cards, int> Cards = new Dictionary<Cards, int>();
    protected int Gold;
    protected string Name;


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

    public Player(int gold, string name)
    {
        Gold = 0;
        Name = name;
        Cards = new Dictionary<Cards, int> { {champsdeble, 1 }, { new Champsdeble(), 1 } };
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
