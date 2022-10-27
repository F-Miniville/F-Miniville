using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceManager : MonoBehaviour
{
    public Dice Dice1;
    public Dice Dice2;

    [SerializeField] GameObject cameraObject;
    [SerializeField] Camera cameraScript;

    public int result;
    public bool alreadyClick = true;

    void Start()
    {

        cameraObject = GameObject.FindWithTag("MainCamera");
        cameraScript = cameraObject.GetComponent<Camera>();

        Vector3 p = cameraScript.ScreenToWorldPoint(new Vector3(Screen.width-(50* Screen.width/640), Screen.height - (22 * Screen.height / 320), 1));
        this.gameObject.GetComponent<Transform>().position = p;


        
    }

    public int RollAllDices()
    {
        Debug.Log("RollDice");
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
        Debug.Log("Get result Roll : " + result);
        return result;
    }
}
