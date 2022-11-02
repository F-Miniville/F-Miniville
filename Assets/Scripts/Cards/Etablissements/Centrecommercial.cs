using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Centrecommercial : Etablissement
{
    public new int costEtablissement = 10;
    [SerializeField] GameObject prefab;

    public Centrecommercial() : base()
    {

    }

    void OnMouseDown()
    {
        Debug.Log("OnMouseDown Centrecommercial");

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

        if (Game.instance._Boutique && (_PlayerGold >= costEtablissement) && _PeuxAcheter)
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

    public override void IAAchatEtablisement()
    {
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

        if (Game.instance._Boutique && (_PlayerGold >= costEtablissement) && _PeuxAcheter)
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
