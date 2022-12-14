using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceManager : MonoBehaviour
{
    static public DiceManager instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.Log("Il y a plus d'une Instance de DiceManager dans la scene");
            return;
        }
        instance = this;
    }

    public Dice Dice1;
    public Dice Dice2;

    [SerializeField] GameObject cameraObject;
    [SerializeField] Camera cameraScript;

    public Animator animatorDice1;
    public Animator animatorDice2;

    public int result;
    public bool secondDice = false;
    public bool playerChoiceDice = false;
    bool _haveRollTwoDice = false;

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

        int resultDice1 = Dice1.RollDices();
        animatorDice1.SetInteger("FaceDice1", resultDice1);
        result += resultDice1;


        int resultDice2 = 0;
        if ((secondDice && playerChoiceDice) || (secondDice && Game.instance._IA && Random.Range(0 ,2) == 1))
        {
            resultDice2 = Dice2.RollDices();
            animatorDice2.SetInteger("FaceDice2", resultDice2);
            result += resultDice2;
            playerChoiceDice = false;
            _haveRollTwoDice = true;
        }
        else
        {
            _haveRollTwoDice = false;
        }

        bool _haveParc = false;
        List<Etablissement> list = Game.instance.playerTurn.GetComponent<Player>().etablissements;
        foreach(Etablissement item in list)
        {
            if(item.GetType().ToString() == "Parcdattraction")
            {
                _haveParc = true;
                break;
            }
        }

        if (resultDice1 == resultDice2 && _haveParc)
        {
            Game.instance._intPlayerTurn--;
        }


        Debug.Log("Get result Roll : " + result);
        return result;
    }

    public int ReRollDice()
    {
        Game.instance.AnimateRollDice();
        Debug.Log("ReRollDice");
        result = 0;

        int resultDice1 = Dice1.RollDices();
        animatorDice1.SetInteger("FaceDice1", resultDice1);
        result += resultDice1;


        if (_haveRollTwoDice)
        {
            int resultDice2 = Dice2.RollDices();
            animatorDice2.SetInteger("FaceDice2", resultDice2);
            result += resultDice2;
            playerChoiceDice = false;
            _haveRollTwoDice = false;
        }



        Debug.Log("Get result Roll : " + result);
        return result;
    }
}
