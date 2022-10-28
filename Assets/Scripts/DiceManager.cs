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

    [SerializeField] Gare gare;

    public Animator animatorDice1;
    public Animator animatorDice2;

    public int result;
    public bool alreadyClick = true;

    void Start()
    {

        cameraObject = GameObject.FindWithTag("MainCamera");
        cameraScript = cameraObject.GetComponent<Camera>();

        Vector3 p = cameraScript.ScreenToWorldPoint(new Vector3(Screen.width-(50* Screen.width/640), Screen.height - (22 * Screen.height / 320), 1));
        this.gameObject.GetComponent<Transform>().position = p;


        
    }

    public int RollAllDices(GameObject player)
    {
        bool secondDice = false;
        Debug.Log("RollDice");
        result = 0;
        if (!alreadyClick)
        {
            alreadyClick = true;
            int resultDice1 = Dice1.RollDices();
            animatorDice1.SetInteger("FaceDice1", resultDice1);
            result += resultDice1;

            Player _PlayerScript = player.GetComponent<Player>();

            foreach(Etablissement etablissement in _PlayerScript.etablissements)
            {
                if(etablissement.GetType() == gare.GetType())
                {
                    secondDice = true;
                }
            }

            if (secondDice)
            {
                int resultDice2 = Dice2.RollDices();
                animatorDice2.SetInteger("FaceDice2", resultDice2);
                result += resultDice2;
            }
        }
        
        Debug.Log("Get result Roll : " + result);
        return result;
    }
}
