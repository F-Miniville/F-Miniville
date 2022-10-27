using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenCards : Cards
{

<<<<<<< Updated upstream
    int costCards;
    public GreenCards(List<int> activationCost, int costCards, string cardName) : base(activationCost, costCards, cardName)
=======

    public GreenCards(List<int> activationCost, int costCards, string cardName, string color) : base(activationCost, costCards, cardName, color)
>>>>>>> Stashed changes
    {

    }
}
