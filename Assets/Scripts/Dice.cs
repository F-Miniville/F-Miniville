using System.Collections;
using UnityEngine;

public class Dice : MonoBehaviour
{

    private Sprite[] diceSides;
    private SpriteRenderer rend;

    private int finalSide;

    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        diceSides = Resources.LoadAll<Sprite>("DiceSides/");
    }

    public int RollDices()
    {
        finalSide = 0;
        int randomDiceSide = Random.Range(0, 5);

        finalSide = randomDiceSide + 1;


        Debug.Log(finalSide);
        return finalSide;
    }

    public void RollTheDice()
    {
        int random;
        for (int i = 0; i <= 20; i++)
        {
            random = Random.Range(0, 5);
            rend.sprite = diceSides[random];
        }
        rend.sprite = diceSides[finalSide];
    }

    public SpriteRenderer Rend
    {
        get { return rend; }
        set { rend = value; }
    }
}
