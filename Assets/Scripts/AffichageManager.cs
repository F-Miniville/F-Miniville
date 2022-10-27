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

    public void RefreshHand(List<GameObject> LP)
    {
        List<string> alreadydo = new List<string>();
        Dictionary<string, int> nbr = CreateDictionnary(LP);
        int j = 1;
        int ligne = 1;
        foreach (GameObject P in LP)
        {
            if (!alreadydo.Contains(P.name))
            {
                for (int i = 0; i < nbr[P.name]; i++)
                {
                    Instantiate(P, camera.ScreenToWorldPoint(new Vector3(Screen.width / 2 - P.GetComponent<SpriteRenderer>().sprite.pixelsPerUnit * (j * (0.4f * Screen.width / 640)) + (Screen.width / 5) * 2.115f, Screen.height / 10 + i * 20f, 1 + j / 10)), Quaternion.identity);
                    infoCard inf = P.AddComponent<infoCard>();
                    inf.name = P.name;
                    inf.Square = Square;
                    BoxCollider2D bc = P.AddComponent(typeof(BoxCollider2D)) as BoxCollider2D;
                    bc.size = new Vector2(5, 8);
                    bc.isTrigger = true;
                    P.GetComponent<Transform>().localScale = new Vector3(0.3f, 0.3f, 0.3f);
                    

                    alreadydo.Add(P.name);
                }
                j++;
            }



        }
    }



    public void RefreshPile(List<Pile> LP)
    {
        int j = 1;
        int ligne = 1;
        foreach (Pile P in LP)
        {
            for (int i = 0; i < P.cardsInPile.Count; i++)
            {
                GameObject card = P.cardsInPile[i];
                Instantiate(card, camera.ScreenToWorldPoint(new Vector3(Screen.width / 2 - card.GetComponent<SpriteRenderer>().sprite.pixelsPerUnit * (j * (0.5f * Screen.width / 640)) + (Screen.width / 5) * 1.57f, Screen.height / 5 * (4 - ligne) - i * 6f, 1)), Quaternion.identity);
                infoCard inf = card.AddComponent<infoCard>();
                inf.name = card.name;
                inf.Square = Square;
                BoxCollider2D bc = card.AddComponent(typeof(BoxCollider2D)) as BoxCollider2D;
                bc.size = new Vector2(5, 8);
                bc.isTrigger = true;
                card.GetComponent<Transform>().localScale = new Vector3(0.3f, 0.3f, 0.3f);

            }
            if (j % 7 == 0)
            {
                ligne += 1;
                j = 0;
            }
            j++;


        }
    }

    private Dictionary<string, int> CreateDictionnary(List<GameObject> list)
    {
        Dictionary<string, int> dict = new Dictionary<string, int>();

        foreach (GameObject c in list)
        {
            if (dict.ContainsKey(c.name))
            {
                dict[c.name] += 1;
            }
            else
            {
                dict[c.name] = 1;
            }
        }

        return dict;
    }



}