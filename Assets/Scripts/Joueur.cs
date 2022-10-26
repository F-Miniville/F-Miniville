using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joueur : MonoBehaviour
{

    [SerializeField] int Gold;
    [SerializeField] List<Etablissement> etablissements;
    [SerializeField] List<GameObject> cards;

    [SerializeField] GameObject boulangeriePrefab;
    [SerializeField] GameObject boulangerieObject;
    [SerializeField] Boulangerie boulangerieScript;

    public void Start()
    {
        cards.Add(boulangeriePrefab);
        boulangerieObject = cards[0];
        boulangerieScript = boulangerieObject.GetComponent<Boulangerie>();

        ReadCards(boulangerieScript);

    }

    public void ReadCards(Cards card)
    {
        Debug.Log(card.name);
    }
}
