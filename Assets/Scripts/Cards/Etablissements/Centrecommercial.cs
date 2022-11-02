using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Centrecommercial : Etablissement
{
    readonly int costEtablissement = 10;
    [SerializeField] GameObject prefab;

    public Centrecommercial() : base()
    {

    }

    void OnMouseDown()
    {
        Debug.Log("OnMouseDown Centrecommercial");

        Player _playerScript = Game.instance.playerTurn.GetComponent<Player>();
        int _PlayerGold = _playerScript.Gold;

        if (Game.instance._Boutique && (_PlayerGold >= costEtablissement))
        {
            _playerScript.Gold -= costEtablissement;

            GameObject instance = Instantiate(prefab);
            instance.transform.position = new Vector3(1000, 1000, 0);
            _playerScript.etablissements.Add(instance.GetComponent<Centrecommercial>());

            this.gameObject.GetComponent<infoCard>().WhenDestroy();

            Game.instance.RefreshScreen();

            Debug.Log(Game.instance.playerTurn.name + " à acheter " + this.name);

            Game.instance._Boutique = false;

        }
    }

}
