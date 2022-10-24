using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    protected Dictionary<Cards, int> Cards = new Dictionary<Cards, int>();
    protected int Gold;
    protected string Name;

    public Player(string name)
    {
        Gold = 0;
        Name = name;
        Cards = new Dictionary<Cards, int> { { new Champsdeble(), 1 }, { new Champsdeble(), 1 } };
    }

    public void spendGold(int i)
    {
        Gold -= i;
        if (Gold < 0)
        {
            Gold = 0;
        }
    }
    public void earnGold(int i)
    {
        Gold += i;
    }
}
