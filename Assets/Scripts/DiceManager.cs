using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceManager : MonoBehaviour
{
    public Camera camera;
    public Dice Dice1;
    public Dice Dice2;
    private Game game;
    private int result;
    public int Result { get; }
    private bool alreadyClick = true;
    public bool AlreadyClick { get; set; }

    public void OnMouseDown()
    {
        result = 0;
        if (!alreadyClick)
        {
            alreadyClick = true;
            result += Dice1.RollDices();
            if (game.OneMoreDice)
            {
                result += Dice2.RollDices();
            }
        }
    }

    void Start()
    {
        Vector3 p = camera.ScreenToWorldPoint(new Vector3(Screen.width-40, Screen.height -22, 1));
        this.gameObject.GetComponent<Transform>().position = p;
    }
}
