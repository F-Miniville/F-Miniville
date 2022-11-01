using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class infoCard : MonoBehaviour
{
    bool condi = true;
    public Dictionary<string, string> Desc;
    public string _name;
    public GameObject newObj;
    public GameObject square;
    public Sprite Square;
    [SerializeField] AudioSource audioSource;

    void Start()
    {
        Desc = new Dictionary<string, string>() { { "Boulangerie", "2 ~ 3\nBoulangerie\n\nPendant votre tour uniquement.\nRecevez 1 pièce de la banque.\n\nCoût : 1" }, { "Café", "3\nCafé\n\nRecevez 1 pièce du joueur qui a lancé les dés.\n\nCoût : 2" }, { "Centre d'affaires", "6\nCentre d'affaires\n\nPendant votre tour uniquement.\nVous pouvez échanger avec le joueur de votre choix un établissement qui ne soit pas de type .....\n\nCoût : 8" }, { "Chaîne de télévision", "6\nChaîne de télévision\n\nPendant votre tour uniquement.\nRecevez 5 pièce du joueur de votre choix.\n\nCoût : 7" }, { "Champs de blé", "1\nChamps de blé\n\nPendant le tour de n'importe quel joueur.\nRecevez 1 pièce de la banque.\n\nCoût : 1" }, { "Fabrique de meubles", "8\nFabrique de meubles\n\nPendant votre tour uniquement.\nRecevez 3 pièce de la banque pour chaque établissement de type ... que vous possédez.\n\nCoût : 3" }, { "Ferme", "2\nFerme\n\nPendant le tour de n'importe quel joueur.\nRecevez 1 pièce de la banque.\n\nCoût : 1" }, { "Forêt", "5\nForêt\n\nPendant le tour de n'importe quel joueur.\nRecevez 1 pièce de la banque.\n\nCoût : 1" }, { "Fromagerie", "7\nFromagerie\n\nPendant votre tour uniquement.\nRecevez 3 pièce de la banque pour chaque établissement de type ... que vous possédez.\n\nCoût : 5" }, { "Marché de fruits et légumes", "11 ~ 12\nMarché de fruits et légumes\n\nPendant votre tour uniquement.\nRecevez 2 pièce de la banque pour chaque établissement de type ... que vous possédez.\n\nCoût : 2" }, { "Mine", "9\nMine\n\nPendant le tour de n'importe quel joueur.\nRecevez 5 pièce de la banque.\n\nCoût : 6" }, { "Restaurant", "9 ~ 10\nRestaurant\n\nRecevez 2 pièces du joueurs qui a lancé les dés\n\nCoût : 3" }, { "Stade", "6\nStade\n\nPendant votre tour uniquement.\nRecevez 2 pièces de la part de chaque autre joueur.\n\nCoût : 6" }, { "Supérette", "4\nSupérette\n\nPendant votre tour uniquement.\nRecevez 3 pièce de la banque.\n\nCoût : 2" }, { "Verger", "10\nVerger\n\nPendant le tour de n'importe quel joueur.\nRecevez 3 pièce de la banque.\n\nCoût : 3" } };
        
    }

    void OnMouseOver()
    {
        if (condi)
        {
            audioSource.Play();

            newObj = new GameObject("text", typeof(infoCard));
            newObj.AddComponent<TextMeshPro>();

            newObj.GetComponent<TextMeshPro>().text = Desc[_name];
            newObj.GetComponent<TextMeshPro>().fontSize = 3;
            newObj.GetComponent<RectTransform>().sizeDelta = new Vector2(4, newObj.GetComponent<RectTransform>().sizeDelta.y);
            newObj.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, -9.5f);

            square = new GameObject("fond");
            SpriteRenderer sc = square.AddComponent(typeof(SpriteRenderer)) as SpriteRenderer;
            RectTransform rt = square.AddComponent(typeof(RectTransform)) as RectTransform;
            square.GetComponent<SpriteRenderer>().sprite = Square;
            var m_NewColor = new UnityEngine.Color32(63, 63, 63, 230);
            square.GetComponent<SpriteRenderer>().color = m_NewColor;

            square.GetComponent<RectTransform>().sizeDelta = new Vector2(newObj.GetComponent<RectTransform>().sizeDelta.x, newObj.GetComponent<RectTransform>().sizeDelta.y);
            square.GetComponent<RectTransform>().localScale = new Vector3(square.GetComponent<RectTransform>().sizeDelta.x, square.GetComponent<RectTransform>().sizeDelta.y - 1, 1);
            square.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, -9.4f);

            condi = false;
        }
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = Camera.main.nearClipPlane;
        if (mousePos.x > Screen.width * 0.8f)
        {
            if (mousePos.y < Screen.height * 0.3f)
            {
                newObj.GetComponent<RectTransform>().anchoredPosition = Camera.main.ScreenToWorldPoint(new Vector3(mousePos.x, Screen.height * 0.3f, mousePos.z));
                newObj.GetComponent<RectTransform>().anchoredPosition = new Vector3(newObj.GetComponent<RectTransform>().anchoredPosition.x - newObj.GetComponent<RectTransform>().sizeDelta.x / 2 - 0.4f, newObj.GetComponent<RectTransform>().anchoredPosition.y + newObj.GetComponent<RectTransform>().sizeDelta.y, 2);
                square.GetComponent<RectTransform>().anchoredPosition = Camera.main.ScreenToWorldPoint(new Vector3(mousePos.x, Screen.height * 0.3f, mousePos.z));
                square.GetComponent<RectTransform>().anchoredPosition = new Vector3(square.GetComponent<RectTransform>().anchoredPosition.x - square.GetComponent<RectTransform>().sizeDelta.x / 2 - 0.4f, square.GetComponent<RectTransform>().anchoredPosition.y + square.GetComponent<RectTransform>().sizeDelta.y - 0.5f, 2);
                newObj.GetComponent<RectTransform>().localPosition = new Vector3(newObj.GetComponent<RectTransform>().localPosition.x, -6, newObj.GetComponent<RectTransform>().localPosition.z);
                square.GetComponent<RectTransform>().localPosition = new Vector3(newObj.GetComponent<RectTransform>().localPosition.x, -5.5f, newObj.GetComponent<RectTransform>().localPosition.z);
            }
            else
            {
                newObj.GetComponent<RectTransform>().anchoredPosition = Camera.main.ScreenToWorldPoint(mousePos);
                newObj.GetComponent<RectTransform>().anchoredPosition = new Vector3(newObj.GetComponent<RectTransform>().anchoredPosition.x - newObj.GetComponent<RectTransform>().sizeDelta.x / 2 - 0.4f, newObj.GetComponent<RectTransform>().anchoredPosition.y - newObj.GetComponent<RectTransform>().sizeDelta.y / 2, 2);
                square.GetComponent<RectTransform>().anchoredPosition = Camera.main.ScreenToWorldPoint(mousePos);
                square.GetComponent<RectTransform>().anchoredPosition = new Vector3(square.GetComponent<RectTransform>().anchoredPosition.x - square.GetComponent<RectTransform>().sizeDelta.x / 2 - 0.4f, square.GetComponent<RectTransform>().anchoredPosition.y - square.GetComponent<RectTransform>().sizeDelta.y / 2 + 0.5f, 2);
            }

        }
        else
        {
            if (mousePos.y < Screen.height * 0.3f)
            {
                newObj.GetComponent<RectTransform>().anchoredPosition = Camera.main.ScreenToWorldPoint(new Vector3(mousePos.x, 0, mousePos.z));
                newObj.GetComponent<RectTransform>().anchoredPosition = new Vector3(newObj.GetComponent<RectTransform>().anchoredPosition.x + newObj.GetComponent<RectTransform>().sizeDelta.x / 2 + 0.4f, newObj.GetComponent<RectTransform>().anchoredPosition.y + newObj.GetComponent<RectTransform>().sizeDelta.y, 2);
                square.GetComponent<RectTransform>().anchoredPosition = Camera.main.ScreenToWorldPoint(new Vector3(mousePos.x, 0, mousePos.z));
                square.GetComponent<RectTransform>().anchoredPosition = new Vector3(square.GetComponent<RectTransform>().anchoredPosition.x + square.GetComponent<RectTransform>().sizeDelta.x / 2 + 0.4f, square.GetComponent<RectTransform>().anchoredPosition.y + square.GetComponent<RectTransform>().sizeDelta.y - 0.5f, 2);
                newObj.GetComponent<RectTransform>().localPosition = new Vector3(newObj.GetComponent<RectTransform>().localPosition.x, -6, newObj.GetComponent<RectTransform>().localPosition.z);
                square.GetComponent<RectTransform>().localPosition = new Vector3(newObj.GetComponent<RectTransform>().localPosition.x, -5.5f, newObj.GetComponent<RectTransform>().localPosition.z);
            }
            else
            {
                newObj.GetComponent<RectTransform>().anchoredPosition = Camera.main.ScreenToWorldPoint(mousePos);
                newObj.GetComponent<RectTransform>().anchoredPosition = new Vector3(newObj.GetComponent<RectTransform>().anchoredPosition.x + newObj.GetComponent<RectTransform>().sizeDelta.x / 2 + 0.4f, newObj.GetComponent<RectTransform>().anchoredPosition.y - newObj.GetComponent<RectTransform>().sizeDelta.y / 2, 2);
                square.GetComponent<RectTransform>().anchoredPosition = Camera.main.ScreenToWorldPoint(mousePos);
                square.GetComponent<RectTransform>().anchoredPosition = new Vector3(square.GetComponent<RectTransform>().anchoredPosition.x + square.GetComponent<RectTransform>().sizeDelta.x / 2 + 0.4f, square.GetComponent<RectTransform>().anchoredPosition.y - square.GetComponent<RectTransform>().sizeDelta.y / 2 + 0.5f, 2);
            }

        }

    }

    void OnMouseExit()
    {
        Destroy(newObj);
        Destroy(square);
        condi = true;
    }
}