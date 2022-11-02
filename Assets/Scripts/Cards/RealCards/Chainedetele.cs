using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chainedetele : PurpleCards
{
    public Chainedetele(List<int> activationCost, int costCards, string cardName, string color) : base(activationCost, costCards, cardName, color)
    {

    }

    public override void effectCards(Player p, List<Player> enemy, int result)
    {    
        if (activationCost.Contains(result))
        {
            int _playerAleatoire = Random.Range(0, enemy.Count);
            Player _enemy = enemy[_playerAleatoire];

            int add = 0;
            if(_enemy.Gold < 5)
            {
                add = _enemy.Gold;
                _enemy.Gold -= _enemy.Gold;
            }
            else
            {
                add = 5;
                _enemy.Gold -= 5;
            }

            p.earnGold(add);

        }
    }
}
