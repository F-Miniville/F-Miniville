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
            }
            cardList.Clear();
        }
    }

    public void RefreshHand(List<GameObject> LP, int intplayer)
    {
        var newObj = new GameObject("Nom Joueur" + intplayer);
        cardList.Add(newObj);
        newObj.AddComponent<TextMeshPro>();

        newObj.GetComponent<TextMeshPro>().text = "Joueur " + intplayer;
        newObj.GetComponent<TextMeshPro>().fontSize = 4;

        if (intplayer == 1)
        {
            newObj.GetComponent<RectTransform>().localPosition = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width / 1.585f, Screen.height / 20, 1));
        }
        if (intplayer == 2)
        {
            newObj.GetComponent<RectTransform>().localPosition = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width / 1.585f, Screen.height / 1.55f, 1));
        }
        if (intplayer == 3)
        {
            newObj.GetComponent<RectTransform>().localPosition = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width / 2.55f, Screen.height / 1.5f, 1));
        }
        if (intplayer == 4)
        {
            newObj.GetComponent<RectTransform>().localPosition = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width / 0.775f, Screen.height / 1.5f, 1));
        }

        List<string> alreadydo = new List<string>();
        Dictionary<string, int> nbr = CreateDictionnary(LP);
        int j = 1;
        int colonne = 0;
        int k = 1;
        Debug.Log(LP[1]);
        foreach (GameObject P in LP)
        {
            if (!alreadydo.Contains(P.name))
            {
                for (int i = 0; i < nbr[P.name]; i++)
                {
                    if (intplayer == 1)
                    {
                        cardList.Add(Instantiate(P, cameraScript.ScreenToWorldPoint(new Vector3(Screen.width / 2.5f + ((P.GetComponent<SpriteRenderer>().bounds.size.x * 100) / 4) * (j - 1), Screen.height / 10 + i * 20f, 1 + j + i)), Quaternion.identity));
                    }
                    else if (intplayer == 2)
                    {
                        cardList.Add(Instantiate(P, cameraScript.ScreenToWorldPoint(new Vector3(Screen.width / 2.5f + ((P.GetComponent<SpriteRenderer>().bounds.size.x * 100) / 4) * (j - 1), Screen.height / 1.1f + i * -20f, 1 + j + i)), Quaternion.identity));
                    }
                    else if (intplayer == 3)
                    {
                        cardList.Add(Instantiate(P, cameraScript.ScreenToWorldPoint(new Vector3(Screen.width / 22.5f + colonne * (P.GetComponent<SpriteRenderer>().bounds.size.y * 50), Screen.height / 1.5f + ((P.GetComponent<SpriteRenderer>().bounds.size.y * 100) / 6) * -(k - 1), 15 - k)), Quaternion.identity));
                        if (k % 8 == 0)
                        {
                            colonne += 1;
                            k = 0;
                        }
                    }
                    else if (intplayer == 4)
                    {
                        cardList.Add(Instantiate(P, cameraScript.ScreenToWorldPoint(new Vector3(Screen.width / 1.045f + colonne * -(P.GetComponent<SpriteRenderer>().bounds.size.y * 50), Screen.height / 1.5f + ((P.GetComponent<SpriteRenderer>().bounds.size.y * 100) / 6) * -(k - 1), 15 - k)), Quaternion.identity));
                        if (k % 8 == 0)
                        {
                            colonne += 1;
                            k = 0;
                        }
                    }
                    infoCard inf = P.GetComponent<infoCard>();
                    inf.Square = Square;
                    BoxCollider2D bc = P.GetComponent<BoxCollider2D>();
                    bc.size = new Vector2(5, 8);
                    bc.isTrigger = true;
                    P.GetComponent<Transform>().localScale = new Vector3(0.3f, 0.3f, 0.3f);

                    alreadydo.Add(P.name);
                }
                k++;
                j++;
            }



        }
    }

    public void RefreshPiece(int piece, int intplayer)
    {
        var newObj = new GameObject("Piece" + intplayer);
        cardList.Add(newObj);
        newObj.AddComponent<TextMeshPro>();

        newObj.GetComponent<TextMeshPro>().text = "Argent = " + piece;
        newObj.GetComponent<TextMeshPro>().fontSize = 4;
        
        if (intplayer == 1)
        {
            newObj.GetComponent<RectTransform>().localPosition = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width / 1.40f, Screen.height / 20, 1));
        }
        if (intplayer == 2)
        {
            newObj.GetComponent<RectTransform>().localPosition = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width / 1.4f, Screen.height / 1.55f, 1));
        }
        if (intplayer == 3)
        {
            newObj.GetComponent<RectTransform>().localPosition = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width / 2.55f, Screen.height / 1.6f, 1));
        }
        if (intplayer == 4)
        {
            newObj.GetComponent<RectTransform>().localPosition = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width / 0.775f, Screen.height / 1.6f, 1));
        }
    }

    public void RefreshMonuments(List<Etablissement> Eta, int intplayer)
    {
        Dictionary<string, GameObject> listeEta = new Dictionary<string, GameObject>() { {"Centreccommercial" , centrecommercialRE}, {"Gare", gareRE }, { "Parcdattraction", parcdattractionRE }, { "Tourradio", tourradioRE } };
        Dictionary<string, GameObject> listeEtaChange = new Dictionary<string, GameObject>() { { "Centrecommercial", centrecommercial }, { "Gare", gare }, { "Parcdattraction", parcdattraction }, { "Tourradio", tourradio } };
        foreach (Etablissement E in Eta)
        {
            listeEta[E.GetType().ToString()] = listeEtaChange[E.GetType().ToString()];
        }
        int i = 1;
        int ligne = 0;
        int j = 1;
        foreach (var EO in listeEta)
        {
            if (intplayer == 1)
            {
                cardList.Add(Instantiate(EO.Value, cameraScript.ScreenToWorldPoint(new Vector3(Screen.width / 3.5f + ((EO.Value.GetComponent<SpriteRenderer>().bounds.size.x * ((23f + 1/3) * (Screen.width / 640)))) * (j - 1), Screen.height / (9 + ligne*3), 2 - ligne)), Quaternion.identity));
            }
            if (intplayer == 2)
            {
                cardList.Add(Instantiate(EO.Value, cameraScript.ScreenToWorldPoint(new Vector3(Screen.width / 3.5f + ((EO.Value.GetComponent<SpriteRenderer>().bounds.size.x * ((23f + 1 / 3) * (Screen.width / 640)))) * (j - 1), Screen.height / (1.09f + ligne * 0.03f), 2 - ligne)), Quaternion.identity));
            }
            if (intplayer == 3)
            {
                cardList.Add(Instantiate(EO.Value, cameraScript.ScreenToWorldPoint(new Vector3(Screen.width / 22.5f + ((EO.Value.GetComponent<SpriteRenderer>().bounds.size.x * ((23f + 1 / 3) * (Screen.width / 640)))) * (j - 1), Screen.height / (4 + ligne * 0.6f), 2 - ligne)), Quaternion.identity));
            }
            if (intplayer == 4)
            {
                cardList.Add(Instantiate(EO.Value, cameraScript.ScreenToWorldPoint(new Vector3((Screen.width / 1.045f) - ((EO.Value.GetComponent<SpriteRenderer>().bounds.size.x * ((23f + 1 / 3) * (Screen.width / 640)))) + ((EO.Value.GetComponent<SpriteRenderer>().bounds.size.x * ((23f + 1 / 3) * (Screen.width / 640)))) * (j - 1), Screen.height / (4 + ligne * 0.6f), 2 - ligne)), Quaternion.identity));
            }

            i++;
            j++;

            if ( j % 3 ==0)
            {
                ligne += 1;
                j = 1;
            }

        }
    }

    public void RefreshPile(List<GameObject> LP)
    {
        int j = 1;
        int ligne = 1;
        foreach (GameObject P in LP)
        {
                P.GetComponent<Transform>().position = cameraScript.ScreenToWorldPoint(new Vector3(Screen.width / 2 - P.GetComponent<SpriteRenderer>().sprite.pixelsPerUnit * (j * (0.5f * Screen.width / 640)) + (Screen.width / 5) * 1.57f, Screen.height / 5 * (4 - ligne), 1));
                infoCard inf = P.GetComponent<infoCard>();
                inf.Square = Square;
                BoxCollider2D bc = P.GetComponent<BoxCollider2D>();
                bc.size = new Vector2(5, 8);
                bc.isTrigger = true;
                P.GetComponent<Transform>().localScale = new Vector3(0.3f, 0.3f, 0.3f);


            if (j % 8 == 0)
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