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
        StartCoroutine("RollTheDice");
        return finalSide;
    }

    private IEnumerator RollTheDice()
    {
        int randomDiceSide = 0;

        for (int i = 0; i <= 20; i++)
        {
            randomDiceSide = Random.Range(0, 5);
            rend.sprite = diceSides[randomDiceSide];
            yield return new WaitForSeconds(0.05f);
        }

        finalSide = randomDiceSide + 1;
        Debug.Log(finalSide); // Show final dice value in Console
    }

    public SpriteRenderer Rend
    {
        get { return rend; }
        set { rend = value; }
    }
}
