using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceManager : MonoBehaviour
{
    public Dice Dice1;
    public Dice Dice2;

    public void OnMouseDown()
    {
        Dice1.RollDices();
        Dice2.RollDices();
    }
}
