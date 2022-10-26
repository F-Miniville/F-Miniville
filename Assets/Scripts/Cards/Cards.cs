using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;

public abstract class Cards : MonoBehaviour
{

    List<int> activationCost;

    int costCards;

    public string cardName;

    public string color;

    public Cards(List<int> activationCost, int costCards, string cardName, string color)
    {
        this.cardName = cardName;
        this.color = color;
    }
}
