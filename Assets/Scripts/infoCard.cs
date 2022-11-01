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
        Desc = new Dictionary<string, string>() { { "Boulangerie", "2 ~ 3\nBoulangerie\n\nPendant votre tour uniquement.\nRecevez 1 pi�ce de la banque.\n\nCo�t : 1" }, { "Caf�", "3\nCaf�\n\nRecevez 1 pi�ce du joueur qui a lanc� les d�s.\n\nCo�t : 2" }, { "Centre d'affaires", "6\nCentre d'affaires\n\nPendant votre tour uniquement.\nVous pouvez �changer avec le joueur de votre choix un �tablissement qui ne soit pas de type .....\n\nCo�t : 8" }, { "Cha�ne de t�l�vision", "6\nCha�ne de t�l�vision\n\nPendant votre tour uniquement.\nRecevez 5 pi�ce du joueur de votre choix.\n\nCo�t : 7" }, { "Champs de bl�", "1\nChamps de bl�\n\nPendant le tour de n'importe quel joueur.\nRecevez 1 pi�ce de la banque.\n\nCo�t : 1" }, { "Fabrique de meubles", "8\nFabrique de meubles\n\nPendant votre tour uniquement.\nRecevez 3 pi�ce de la banque pour chaque �tablissement de type ... que vous poss�dez.\n\nCo�t : 3" }, { "Ferme", "2\nFerme\n\nPendant le tour de n'importe quel joueur.\nRecevez 1 pi�ce de la banque.\n\nCo�t : 1" }, { "For�t", "5\nFor�t\n\nPendant le tour de n'importe quel joueur.\nRecevez 1 pi�ce de la banque.\n\nCo�t : 1" }, { "Fromagerie", "7\nFromagerie\n\nPendant votre tour uniquement.\nRecevez 3 pi�ce de la banque pour chaque �tablissement de type ... que vous poss�dez.\n\nCo�t : 5" }, { "March� de fruits et l�gumes", "11 ~ 12\nMarch� de fruits et l�gumes\n\nPendant votre tour uniquement.\nRecevez 2 pi�ce de la banque pour chaque �tablissement de type ... que vous poss�dez.\n\nCo�t : 2" }, { "Mine", "9\nMine\n\nPendant le tour de n'importe quel joueur.\nRecevez 5 pi�ce de la banque.\n\nCo�t : 6" }, { "Restaurant", "9 ~ 10\nRestaurant\n\nRecevez 2 pi�ces du joueurs qui a lanc� les d�s\n\nCo�t : 3" }, { "Stade", "6\nStade\n\nPendant votre tour uniquement.\nRecevez 2 pi�ces de la part de chaque autre joueur.\n\nCo�t : 6" }, { "Sup�rette", "4\nSup�rette\n\nPendant votre tour uniquement.\nRecevez 3 pi�ce de la banque.\n\nCo�t : 2" }, { "Verger", "10\nVerger\n\nPendant le tour de n'importe quel joueur.\nRecevez 3 pi�ce de la banque.\n\nCo�t : 3" } };
        
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