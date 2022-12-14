using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gare : Etablissement
{
    [SerializeField] GameObject prefab;

    public Gare() : base()
    {

    }

    void OnMouseDown()
    {
        this.costEtablissement = 4;
        Debug.Log("OnMouseDown Gare");

        Player _playerScript = Game.instance.playerTurn.GetComponent<Player>();
        int _PlayerGold = _playerScript.Gold;

        bool _PeuxAcheter = true;
        foreach (Etablissement etablissement in _playerScript.etablissements)
        {
            if (etablissement.GetType() == this.GetType())
            {
                _PeuxAcheter = false;
            }
        }

        if (Game.instance._Boutique && _PlayerGold >= costEtablissement && _PeuxAcheter)
        {
            _playerScript.Gold -= costEtablissement;

            GameObject instance = Instantiate(prefab);
            instance.transform.position = new Vector3(1000, 1000, 0);
            _playerScript.etablissements.Add(instance.GetComponent<Gare>());

            this.gameObject.GetComponent<infoCard>().WhenDestroy();

            Game.instance.RefreshScreen();

            Debug.Log(Game.instance.playerTurn.name + " ? acheter " + this.name);

            Game.instance._Boutique = false;

        }
    }

    public override void IAAchatEtablisement()
    {
        this.costEtablissement = 4;
        Debug.Log("OnMouseDown Tourradio");

        Player _playerScript = Game.instance.playerTurn.GetComponent<Player>();
        int _PlayerGold = _playerScript.Gold;

        bool _PeuxAcheter = true;
        foreach (Etablissement etablissement in _playerScript.etablissements)
        {
            if (etablissement.GetType() == this.GetType())
            {
                _PeuxAcheter = false;
            }
        }

        if (Game.instance._Boutique && _PlayerGold >= costEtablissement && _PeuxAcheter)
        {
            _playerScript.Gold -= costEtablissement;

            GameObject instance = Instantiate(prefab);
            instance.transform.position = new Vector3(1000, 1000, 0);
            _playerScript.etablissements.Add(instance.GetComponent<Gare>());

            this.gameObject.GetComponent<infoCard>().WhenDestroy();

            Game.instance.RefreshScreen();

            Debug.Log(Game.instance.playerTurn.name + " ? acheter " + this.name);

            Game.instance._Boutique = false;

        }
    }
}
