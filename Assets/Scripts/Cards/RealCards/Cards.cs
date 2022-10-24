using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Cards : MonoBehaviour
{

    int activationCost;
    int costCards;

    string cardName;

    public Cards()
    {

    }

    public abstract void effectCards();



}
