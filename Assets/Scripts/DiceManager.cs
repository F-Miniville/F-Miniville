using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceManager : MonoBehaviour
{
    public GameObject cameraObject;
    public Camera cameraScript;
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
            if (true)
            {
                result += Dice2.RollDices();
            }
        }
    }

    void Awake()
    {
        cameraObject = GameObject.FindWithTag("MainCamera");
        cameraScript = cameraObject.GetComponent<Camera>();

        Vector3 p = cameraScript.ScreenToWorldPoint(new Vector3(Screen.width-(50* Screen.width/640), Screen.height - (22 * Screen.height / 320), 1));
        this.gameObject.GetComponent<Transform>().position = p;
    }
}
