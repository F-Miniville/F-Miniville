using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AffichageManager : MonoBehaviour
{
    public Camera camera;

    private Pile P;

    public Sprite boulangerie;
    public Sprite cafe;
    public Sprite centredaffaires;
    public Sprite chainedetele;
    public Sprite champsdeble;
    public Sprite fabriquedemeuble;
    public Sprite ferme;
    public Sprite for�t;
    public Sprite fromagerie;
    public Sprite marchedefuitsetlegumes;
    public Sprite mine;
    public Sprite restaurant;
    public Sprite stade;
    public Sprite superette;
    public Sprite verger;
    private Dictionary<string, Sprite> strSprite;

    public Sprite centrecommercialRE;
    public Sprite centrecommercial;
    public Sprite gareRE;
    public Sprite gare;
    public Sprite parcdattractionRE;
    public Sprite parcdattraction;
    public Sprite tourradioRE;
    public Sprite tourradio;

    public Sprite piece1;
    public Sprite piece5;
    public Sprite piece10;

    public Sprite nothing;

    void Start()
    {
        P = new Pile();
        strSprite = new Dictionary<string, Sprite>() { { "Boulangerie", boulangerie }, { "Cafe", cafe }, { "Centre d'affaires", centredaffaires }, { "Chaine de tele", chainedetele }, { "Champs de bl�", champsdeble }, { "Fabrique de meuble", fabriquedemeuble }, { "Ferme", ferme }, { "For�t", for�t }, { "Fromagerie", fromagerie }, { "Marche de fruits et legumes", marchedefuitsetlegumes }, { "Mine", mine }, { "Restaurant", restaurant }, { "Stade", stade }, { "Superette", superette }, { "Verger", verger } };
        int j = 0;
        int screenWidth20 = Screen.width / 20;
        foreach (var card in P.cards)
        {
            Debug.Log(card.Key);
            string name = card.Key.cardName;
            Debug.Log(name);
            for (int i = 0; i < card.Value; i++)
            {
                GameObject newObj = new GameObject(name);
                Instantiate(newObj, Vector3.zero, Quaternion.identity);

                Vector3 p = camera.ScreenToWorldPoint(new Vector3(screenWidth20 * j + 5, Screen.height / 5 * 2, 0));
                newObj.GetComponent<Transform>().position = p;

                SpriteRenderer sc = newObj.AddComponent(typeof(SpriteRenderer)) as SpriteRenderer;
                newObj.GetComponent<SpriteRenderer>().sprite = strSprite[name];
            }
            j++;
        }
    }

    void Update()
    {
        
    }

}
