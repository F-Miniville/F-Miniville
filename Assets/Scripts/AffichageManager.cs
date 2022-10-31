using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class AffichageManager : MonoBehaviour
{
    static public AffichageManager instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.Log("Il y a plus d'une Instance de AffichageManager dans la scene");
            return;
        }
        instance = this;
    }

    public GameObject cameraObject;
    public Camera cameraScript;
    public Sprite Square;

    private Pile P;

    private Dictionary<string, Sprite> strSprite;

    public GameObject centrecommercialRE;
    public GameObject centrecommercial;
    public GameObject gareRE;
    public GameObject gare;
    public GameObject parcdattractionRE;
    public GameObject parcdattraction;
    public GameObject tourradioRE;
    public GameObject tourradio;

    private List<GameObject> listEta;

    public Sprite piece1;
    public Sprite piece5;
    public Sprite piece10;

    public Sprite nothing;
    
    private List<GameObject> cardList;

    void Start()
    {
        //RefreshHand();
        //RefreshPile();

        cardList = new List<GameObject>();
        listEta = new List<GameObject>() { centrecommercial, gare, parcdattraction, tourradio };
        cameraObject = GameObject.FindWithTag("MainCamera");
        cameraScript = cameraObject.GetComponent<Camera>();
    }

    void Update()
    {

    }

    public void DelCard()
    {
        if (cardList.Count != 0)
        {
            foreach (GameObject GO in cardList)
            {
                Destroy(GO);
                Debug.Log("yeah");
            }
            cardList.Clear();
        }
    }

    public void RefreshHand(List<GameObject> LP)
    {
        
        List<string> alreadydo = new List<string>();
        Dictionary<string, int> nbr = CreateDictionnary(LP);
        int j = 1;
        foreach (GameObject P in LP)
        {
            if (!alreadydo.Contains(P.name))
            {
                for (int i = 0; i < nbr[P.name]; i++)
                {
                    cardList.Add(Instantiate(P, cameraScript.ScreenToWorldPoint(new Vector3(Screen.width/2.5f + ((P.GetComponent<SpriteRenderer>().bounds.size.x * 100) / 4) * (j-1), Screen.height / 10 + i * 20f, 1 + j / 3)), Quaternion.identity));
                    infoCard inf = P.GetComponent<infoCard>();
                    inf.Square = Square;
                    BoxCollider2D bc = P.GetComponent<BoxCollider2D>();
                    bc.size = new Vector2(5, 8);
                    bc.isTrigger = true;
                    P.GetComponent<Transform>().localScale = new Vector3(0.3f, 0.3f, 0.3f);


                    alreadydo.Add(P.name);
                }
                j++;
            }



        }

        for (int i = 0; i < 4; i++)
        {

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
                Instantiate(card, cameraScript.ScreenToWorldPoint(new Vector3(Screen.width / 2 - card.GetComponent<SpriteRenderer>().sprite.pixelsPerUnit * (j * (0.5f * Screen.width / 640)) + (Screen.width / 5) * 1.57f, Screen.height / 5 * (4 - ligne) - i * 6f, 1)), Quaternion.identity);
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