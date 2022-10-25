using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    protected Dictionary<Cards, int> Cards = new Dictionary<Cards, int>();
    protected int Gold;
    protected string Name;

<<<<<<< Updated upstream
    private Champsdeble champsdeble = new Champsdeble();

    public Player(string name)
=======
<<<<<<< HEAD
    public Player(int gold, string name)
>>>>>>> Stashed changes
    {
        Gold = 0;
        Name = name;
<<<<<<< Updated upstream
        Cards = new Dictionary<Cards, int> { {champsdeble, 1 }, { new Champsdeble(), 1 } };
        Cards[champsdeble] += 1;
=======
=======
    private Champsdeble champsdeble = new Champsdeble();

    public Player(string name)
    {
        Gold = 0;
        Name = name;
        Cards = new Dictionary<Cards, int> { {champsdeble, 1 }, { new Champsdeble(), 1 } };
        Cards[champsdeble] += 1;
>>>>>>> main
>>>>>>> Stashed changes
    }

    public void spendGold(int i) 
    {
        Gold -= i;
        if (Gold < 0)
        {
<<<<<<< Updated upstream
            Gold = 0;
=======
<<<<<<< HEAD
            Gold == 0;
=======
            Gold = 0;
>>>>>>> main
>>>>>>> Stashed changes
        }
    }
    public void earnGold(int i)
    {
        Gold += i;
    }
}
