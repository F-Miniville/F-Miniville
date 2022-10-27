using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class AffichageManager : MonoBehaviour
{
    public Camera camera;
    public Sprite Square;

    private Pile P;

    public GameObject boulangerie;
    public GameObject cafe;
    public GameObject centredaffaires;
    public GameObject chainedetele;
    public GameObject champsdeble;
    public GameObject fabriquedemeuble;
    public GameObject ferme;
    public GameObject forêt;
    public GameObject fromagerie;
    public GameObject marchedefuitsetlegumes;
    public GameObject mine;
    public GameObject restaurant;
    public GameObject stade;
    public GameObject superette;
    public GameObject verger;
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
        //RefreshHand();
        //RefreshPile();
    }

    void Update()
    {
        
    }

    /*    public void RefreshHand()
        {
            P = new Pile();
            strSprite = new Dictionary<string, Sprite>() { { "Boulangerie", boulangerie }, { "Cafe", cafe }, { "Centre d'affaires", centredaffaires }, { "Chaine de tele", chainedetele }, { "Champs de blé", champsdeble }, { "Fabrique de meuble", fabriquedemeuble }, { "Ferme", ferme }, { "Forêt", forêt }, { "Fromagerie", fromagerie }, { "Marche de fruits et legumes", marchedefuitsetlegumes }, { "Mine", mine }, { "Restaurant", restaurant }, { "Stade", stade }, { "Superette", superette }, { "Verger", verger } };
            int j = 1;
            int ligne = 1;
            foreach (var card in P.cards)
            {
                if (card.Value != 0)
                {
                    string name = card.Key.cardName;

                    for (int i = 0; i < card.Value; i++)
                    {
                        GameObject newObj = new GameObject(name, typeof(infoCard));
                        newObj.GetComponent<infoCard>().name = name;
                        newObj.GetComponent<infoCard>().Square = Square;
                        SpriteRenderer sc = newObj.AddComponent(typeof(SpriteRenderer)) as SpriteRenderer;
                        BoxCollider2D bc = newObj.AddComponent(typeof(BoxCollider2D)) as BoxCollider2D;
                        bc.size = new Vector2(5, 8);
                        bc.isTrigger = true;
                        newObj.GetComponent<SpriteRenderer>().sprite = strSprite[name];
                        Vector3 p = camera.ScreenToWorldPoint(new Vector3(Screen.width / 2 - newObj.GetComponent<SpriteRenderer>().sprite.pixelsPerUnit * (j * (0.4f * Screen.width / 640)) + (Screen.width / 5) * 2.115f, Screen.height / 10 + i * 20f, 1 + j / 10));
                        newObj.GetComponent<Transform>().position = p;
                        newObj.GetComponent<Transform>().localScale = new Vector3(0.3f, 0.3f, 0.3f);

                    }
                    j++;
                }

            }
        }

        public void RefreshPile()
        {
            P = new Pile();
            strSprite = new Dictionary<string, Sprite>() { { "Boulangerie", boulangerie }, { "Cafe", cafe }, { "Centre d'affaires", centredaffaires }, { "Chaine de tele", chainedetele }, { "Champs de blé", champsdeble }, { "Fabrique de meuble", fabriquedemeuble }, { "Ferme", ferme }, { "Forêt", forêt }, { "Fromagerie", fromagerie }, { "Marche de fruits et legumes", marchedefuitsetlegumes }, { "Mine", mine }, { "Restaurant", restaurant }, { "Stade", stade }, { "Superette", superette }, { "Verger", verger } };
            int j = 1;
            int ligne = 1;
            foreach (var card in P.cards)
            {
                if (card.Value != 0)
                {
                    string name = card.Key.cardName;

                    for (int i = 0; i < card.Value; i++)
                    {
                        GameObject newObj = new GameObject(name, typeof(infoCard));
                        newObj.GetComponent<infoCard>().name = name;
                        newObj.GetComponent<infoCard>().Square = Square;
                        SpriteRenderer sc = newObj.AddComponent(typeof(SpriteRenderer)) as SpriteRenderer;
                        BoxCollider2D bc = newObj.AddComponent(typeof(BoxCollider2D)) as BoxCollider2D;
                        bc.size = new Vector2(5, 8);
                        bc.isTrigger = true;
                        newObj.GetComponent<SpriteRenderer>().sprite = strSprite[name];
                        Vector3 p = camera.ScreenToWorldPoint(new Vector3(Screen.width / 2 - newObj.GetComponent<SpriteRenderer>().sprite.pixelsPerUnit * (j * (0.5f * Screen.width / 640)) + (Screen.width / 5) * 1.57f, Screen.height / 5 * (4 - ligne) - i * 6f, 1));
                        newObj.GetComponent<Transform>().position = p;
                        newObj.GetComponent<Transform>().localScale = new Vector3(0.3f, 0.3f, 0.3f);

                    }
                    if (j % 7 == 0)
                    {
                        ligne += 1;
                        j = 0;
                    }
                    j++;
                }

            }
        }

    */

}