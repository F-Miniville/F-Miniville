using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BlueCards : Cards
{

<<<<<<< Updated upstream
    int costCards;
    public BlueCards(List<int> activationCost, int costCards, string cardName) : base(activationCost, costCards, cardName)
=======
    public BlueCards(List<int> activationCost, int costCards, string cardName, string color) : base(activationCost, costCards, cardName, color)
>>>>>>> Stashed changes
    {

    }
}
