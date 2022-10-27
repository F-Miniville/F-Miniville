using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PurpleCards : Cards
{

<<<<<<< Updated upstream
    int costCards;
    public PurpleCards(List<int> activationCost, int costCards, string cardName) : base(activationCost, costCards, cardName)
=======
    public PurpleCards(List<int> activationCost, int costCards, string cardName, string color) : base(activationCost, costCards, cardName, color)
>>>>>>> Stashed changes
    {

    }
}
