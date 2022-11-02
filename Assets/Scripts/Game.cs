using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEditor;
using System.Text;
using UnityEngine.UI;
using Unity.VisualScripting;
using static UnityEditor.Progress;

public class Game : MonoBehaviour
{
    static public Game instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.Log("Il y a plus d'une Instance de Game dans la scene");
            return;
        }
        instance = this;
    }

    //Gestion des joueurs
    List<GameObject> _PlayersList;
    [SerializeField] GameObject PlayerPrefab;
    [SerializeField] GameObject IAPrefab;
    public GameObject playerTurn;
    [SerializeField] List<GameObject> _PlayerListReel;
    public int _intPlayerTurn;
    [SerializeField] bool _finTour;

    [SerializeField] int nbJoueur;

    [SerializeField] Gare gare;
    [SerializeField] GameObject _TwoDice;
    [SerializeField] GameObject _OneDice;
    [SerializeField] GameObject _EndTurn;
    [SerializeField] GameObject _ReRollDice;
    [SerializeField] GameObject _Execute;

    [SerializeField] GameObject _WinPanel;
    [SerializeField] Text _WinText;

    public bool _IA;
    public bool _Boutique = false;
    int resultDice;

    #region Pile

    public List<GameObject> _PileList;

    [SerializeField] GameObject _BoulangeriePile;
    [SerializeField] GameObject _Boulangerie;
    public int _nbBoulangerie;

    [SerializeField] GameObject _CafePile;
    [SerializeField] GameObject _Cafe;
    public int _nbCafe;

    [SerializeField] GameObject _ChampsDeBlePile;
    [SerializeField] GameObject _ChampsDeBle;
    public int _nbChampsDeBle;

    [SerializeField] GameObject _CentreDAffairePile;
    [SerializeField] GameObject _CentreDAffaire;
    public int _nbCentreDAffaire;

    [SerializeField] GameObject _ChaineDeTelePile;
    [SerializeField] GameObject _ChaineDeTele;
    public int _nbChaineDeTele;

    [SerializeField] GameObject _FabriqueDeMeublePile;
    [SerializeField] GameObject _FabriqueDeMeuble;
    public int _nbFabriqueDeMeuble;

    [SerializeField] GameObject _FermePile;
    [SerializeField] GameObject _Ferme;
    public int _nbFerme;

    [SerializeField] GameObject _FromageriePile;
    [SerializeField] GameObject _Fromagerie;
    public int _nbFromagerie;

    [SerializeField] GameObject _MarcheDeFruitEtLegumePile;
    [SerializeField] GameObject _MarcheDeFruitEtLegume;
    public int _nbMarcheDeFruitEtLegume;

    [SerializeField] GameObject _MinePile;
    [SerializeField] GameObject _Mine;
    public int _nbMine;

    [SerializeField] GameObject _RestaurantPile;
    [SerializeField] GameObject _Restaurant;
    public int _nbRestaurant;

    [SerializeField] GameObject _StadePile;
    [SerializeField] GameObject _Stade;
    public int _nbStade;

    [SerializeField] GameObject _SuperettePile;
    [SerializeField] GameObject _Superette;
    public int _nbSuperette;

    [SerializeField] GameObject _VergerPile;
    [SerializeField] GameObject _Verger;
    public int _nbVerger;

    [SerializeField] GameObject _ForetPile;
    [SerializeField] GameObject _Foret;
    public int _nbForet;

    #endregion
    public void Start()
    {
        //Set nb Player
        nbJoueur = ChoiceNbPlayer.Instance.nbPlayerChoice;

        //Dice
        AnimateRollDice();
        _finTour = true;

        
        



        //Player and IA
        _PlayersList = new List<GameObject>();
        _PlayerListReel = new List<GameObject>();

        for (int i = 0; i < nbJoueur; i++)
        {
            _PlayersList.Add(PlayerPrefab);
        }
        if (ChoiceNbPlayer.Instance._haveIA)
        {
            _PlayersList.Add(IAPrefab);
            ChoiceNbPlayer.Instance._haveIA = false;
        }

        for (int i = 0; i < _PlayersList.Count; i++)
        {
            _PlayerListReel.Add(Instantiate(_PlayersList[i]));

            if (_PlayerListReel[i].tag != "IA")
            {
                _PlayerListReel[i].name = "Player " + (i + 1);
            }
            else
            {
                _PlayerListReel[i].name = "IA";
            }

            Player _playerScript = _PlayerListReel[i].GetComponent<Player>();
            _playerScript._intPlayer = i + 1;
            _playerScript.Gold = 3;
            
        }

        //Pile
        _nbBoulangerie = 4 - _PlayerListReel.Count;
        _nbChampsDeBle = 4 - _PlayerListReel.Count;
        InstanciatePile();

        foreach (GameObject player in _PlayerListReel)
        {
            AffichageManager.instance.RefreshPile(_PileList);
            AffichageManager.instance.RefreshPiece(player.GetComponent<Player>().Gold, player.GetComponent<Player>()._intPlayer);
            AffichageManager.instance.RefreshHand(player.GetComponent<Player>().cardsObject, player.GetComponent<Player>()._intPlayer, _PlayerListReel[0]);
            AffichageManager.instance.RefreshMonuments(player.GetComponent<Player>().etablissements, player.GetComponent<Player>()._intPlayer);
        }

        _intPlayerTurn = 0;

        _WinPanel.SetActive(false);
        PrepareTurn();
    }

    public void PrepareTurn()
    {
        if (_intPlayerTurn >= _PlayerListReel.Count)
        {
            _intPlayerTurn = 0;
        }

        playerTurn = _PlayerListReel[_intPlayerTurn];
        _intPlayerTurn++;

        if (playerTurn.tag == "IA")
        {
            _IA = true;
        }
        else
        {
            _IA = false;
        }

        DiceManager.instance.secondDice = false;
        _EndTurn.SetActive(false);
        _OneDice.SetActive(true);
        _TwoDice.SetActive(false);
        _ReRollDice.SetActive(false);
        _Execute.SetActive(false);

        Player _PlayerListReelScript = playerTurn.GetComponent<Player>();
        foreach (Etablissement etablissement in _PlayerListReelScript.etablissements)
        {
            if (etablissement.GetType() == gare.GetType())
            {
                DiceManager.instance.secondDice = true;
                _TwoDice.SetActive(true);
            }
        }

        if (_finTour && !_IA)
        {
            _finTour = false;
        }


        if (_finTour && _IA)
        {
            //Debug.Log("Coroutine IA");
            //StartCoroutine(IATurn());
            //Debug.Log("Fin Coroutine IA");

            _finTour = false;
            Debug.Log("Tour Player :" + playerTurn);
            int result = DiceManager.instance.RollAllDices();
            ResolutionActionTour(result, playerTurn);
            _Boutique = true;

            IATurn();

            FindeTour();
        }
        RefreshScreen();
    }

    public void TurnWithOneDice()
    {
        PlayOneTurn(playerTurn);
        _OneDice.SetActive(false);
        _TwoDice.SetActive(false);
        _Execute.SetActive(true);
    }
    public void TurnWithTwoDice()
    {
        DiceManager.instance.playerChoiceDice = true;
        PlayOneTurn(playerTurn);
        _OneDice.SetActive(false);
        _TwoDice.SetActive(false);
        _Execute.SetActive(true);
    }

    public void FindeTour()
    {
        if (!_finTour)
        {
            if (CheckWin(playerTurn))
            {
                Debug.Log("Win : " + playerTurn.name);
                _WinPanel.SetActive(true);
                _WinText.text = playerTurn.name + " à Gagné la Parti";
            }
            else
            {
                _Boutique = false;
                AnimateRollDice();
                _finTour = true;
                Debug.Log("Fin Tour : " + playerTurn);
                PrepareTurn();
            }
        }
    }

    public void PlayOneTurn(GameObject player)
    {
        Debug.Log("Tour Player : " + player);
        resultDice = DiceManager.instance.RollAllDices();
        _Boutique = true;
        foreach(Etablissement etablissement in player.GetComponent<Player>().etablissements)
        {
            if (etablissement.GetType().ToString() == "Tourradio")
            {
                _ReRollDice.SetActive(true);
                break;
            }
        }

    }

    public void ExecuteCards()
    {
        ResolutionActionTour(resultDice, playerTurn);
        _ReRollDice.SetActive(false);
        _Execute.SetActive(false);
        _OneDice.SetActive(false);
        _TwoDice.SetActive(false);
        _EndTurn.SetActive(true);
        RefreshScreen();
    }

    public void ReRollAllDice()
    {
        ResolutionActionTour(DiceManager.instance.ReRollDice(), playerTurn);
        _ReRollDice.SetActive(false);
        _Execute.SetActive(false);
        _OneDice.SetActive(false);
        _TwoDice.SetActive(false);
        _EndTurn.SetActive(true);
        RefreshScreen();
    }


    public bool CheckWin(GameObject player)
    {
        bool _win = false;
        int win = 0;
        Player p = player.GetComponent<Player>();

        List<Etablissement> etablissements = p.etablissements;

        foreach(Etablissement etablissement in etablissements)
        {
            if(etablissement.GetType() == typeof(Gare))
            {
                win++;
                break;
            }
        }

        foreach (Etablissement etablissement in etablissements)
        {
            if (etablissement.GetType() == typeof(Tourradio))
            {
                win++;
                break;
            }
        }

        foreach (Etablissement etablissement in etablissements)
        {
            if (etablissement.GetType() == typeof(Centrecommercial))
            {
                win++;
                break;
            }
        }

        foreach (Etablissement etablissement in etablissements)
        {
            if (etablissement.GetType() == typeof(Parcdattraction))
            {
                win++;
                break;
            }
        }

        if (win >= 4)
            _win = true;

        return _win;
    }

    public void ResolutionActionTour(int result, GameObject playerTurn)
    {
        Debug.Log("Resolution Action Tour");
        foreach (GameObject p in _PlayerListReel)
        {
            Player _script = p.GetComponent<Player>();
            _script.ClasifiedCards();

            Debug.Log("Entrer blue cards boucle");
            foreach (Cards card in _script.blueCards)
            {
                Debug.Log("blue card effect");
                card.effectCards(_script, GetEnemy(_script, GetAllPlayer()), result);
            }
            Debug.Log("Sortie blue cards boucle");
        }

        Player playerTurnScript = playerTurn.GetComponent<Player>();
        playerTurnScript.ClasifiedCards();

        Debug.Log("Entrer green cards boucle");
        foreach (Cards card in playerTurnScript.greenCards)
        {
            Debug.Log("green card effect");
            card.effectCards(playerTurnScript, GetEnemy(playerTurnScript, GetAllPlayer()), result);
        }
        Debug.Log("Sortie green cards boucle");

        Debug.Log("Entrer purple cards boucle");
        foreach (Cards card in playerTurnScript.purpleCards)
        {
            Debug.Log("purple card effect");
            card.effectCards(playerTurnScript, GetEnemy(playerTurnScript, GetAllPlayer()), result);
        }
        Debug.Log("Sortie purple cards boucle");


        foreach (Player p in GetEnemy(playerTurnScript, GetAllPlayer()))
        {
            p.ClasifiedCards();

            Debug.Log("Entrer red cards boucle");
            foreach (Cards card in p.redCards)
            {
                Debug.Log("red card effect");
                card.effectCards(p, GetEnemy(p, GetAllPlayer()), result);
            }
            Debug.Log("Sortie red cards boucle");
        }

        Debug.Log("Fin Resolution Action Tour");
    }

    public List<Player> GetEnemy(Player p, List<Player> allPlayer)
    {
        Debug.Log("GetEnemy");
        List<Player> list = new List<Player>();

        foreach (Player player in allPlayer)
        {
            if (player != p)
            {
                list.Add(player);
            }
        }

        Debug.Log("Fin GetEnemy");
        return list;
    }

    public List<Player> GetAllPlayer()

    {
        Debug.Log("GetAllPlayer");
        List<Player> allPlayer = new List<Player>();

        foreach (GameObject p in _PlayerListReel)
        {
            allPlayer.Add(p.GetComponent<Player>());
        }

        Debug.Log("Fin GetAllPlayer");
        return allPlayer;
    }


    public void AnimateRollDice()
    {
        DiceManager.instance.animatorDice1.SetInteger("FaceDice1", 0);
        DiceManager.instance.animatorDice2.SetInteger("FaceDice2", 0);
    }


    public void InstanciatePile()
    {
        _PileList = new List<GameObject>();

        _BoulangeriePile = Instantiate(_BoulangeriePile);
        List<GameObject> _boulangeriePileList = new List<GameObject>();
        for (int i = 0; i < _nbBoulangerie; i++)
        {
            _boulangeriePileList.Add(_Boulangerie);
        }
        if(_boulangeriePileList.Count <= 0)
        {
            Destroy(_BoulangeriePile);
        }
        else
        {
            _PileList.Add(_BoulangeriePile);
            _BoulangeriePile.GetComponent<Pile>().AddCardToPile(_boulangeriePileList);
            _BoulangeriePile.GetComponent<Pile>().costOfCardsInPile = 1;
        }

        _CafePile = Instantiate(_CafePile);
        _PileList.Add(_CafePile);
        List<GameObject> _cafePileList = new List<GameObject>();
        for (int i = 0; i < _nbCafe; i++)
        {
            _cafePileList.Add(_Cafe);
        }
        _CafePile.GetComponent<Pile>().AddCardToPile(_cafePileList);
        _CafePile.GetComponent<Pile>().costOfCardsInPile = 2;

        _ChampsDeBlePile = Instantiate(_ChampsDeBlePile);
        List<GameObject> _champsdeblePileList = new List<GameObject>();
        for (int i = 0; i < _nbChampsDeBle; i++)
        {
            _champsdeblePileList.Add(_ChampsDeBle);
        }
        if(_champsdeblePileList.Count >= 0)
        {
            Destroy(_ChampsDeBlePile);
        }
        else
        {
            _PileList.Add(_ChampsDeBlePile);
            _ChampsDeBlePile.GetComponent<Pile>().AddCardToPile(_champsdeblePileList);
            _ChampsDeBlePile.GetComponent<Pile>().costOfCardsInPile = 1;
        }

        _ChaineDeTelePile = Instantiate(_ChaineDeTelePile);
        _PileList.Add(_ChaineDeTelePile);
        List<GameObject> _ChaineDeTelePileList = new List<GameObject>();
        for (int i = 0; i < _nbChaineDeTele; i++)
        {
            _ChaineDeTelePileList.Add(_ChaineDeTele);
        }
        _ChaineDeTelePile.GetComponent<Pile>().AddCardToPile(_ChaineDeTelePileList);
        _ChaineDeTelePile.GetComponent<Pile>().costOfCardsInPile = 7;

        _FabriqueDeMeublePile = Instantiate(_FabriqueDeMeublePile);
        _PileList.Add(_FabriqueDeMeublePile);
        List<GameObject> _FabriqueDeMeublePileList = new List<GameObject>();
        for (int i = 0; i < _nbFabriqueDeMeuble; i++)
        {
            _FabriqueDeMeublePileList.Add(_FabriqueDeMeuble);
        }
        _FabriqueDeMeublePile.GetComponent<Pile>().AddCardToPile(_FabriqueDeMeublePileList);
        _FabriqueDeMeublePile.GetComponent<Pile>().costOfCardsInPile = 3;

        _FermePile = Instantiate(_FermePile);
        _PileList.Add(_FermePile);
        List<GameObject> _FermePileList = new List<GameObject>();
        for (int i = 0; i < _nbFerme; i++)
        {
            _FermePileList.Add(_Ferme);
        }
        _FermePile.GetComponent<Pile>().AddCardToPile(_FermePileList);
        _FermePile.GetComponent<Pile>().costOfCardsInPile = 1;

        _FromageriePile = Instantiate(_FromageriePile);
        _PileList.Add(_FromageriePile);
        List<GameObject> _FromageriePileList = new List<GameObject>();
        for (int i = 0; i < _nbFromagerie; i++)
        {
            _FromageriePileList.Add(_Fromagerie);
        }
        _FromageriePile.GetComponent<Pile>().AddCardToPile(_FromageriePileList);
        _FromageriePile.GetComponent<Pile>().costOfCardsInPile = 5;

        _MarcheDeFruitEtLegumePile = Instantiate(_MarcheDeFruitEtLegumePile);
        _PileList.Add(_MarcheDeFruitEtLegumePile);
        List<GameObject> _MarcheDeFruitEtLegumePileList = new List<GameObject>();
        for (int i = 0; i < _nbMarcheDeFruitEtLegume; i++)
        {
            _MarcheDeFruitEtLegumePileList.Add(_MarcheDeFruitEtLegume);
        }
        _MarcheDeFruitEtLegumePile.GetComponent<Pile>().AddCardToPile(_MarcheDeFruitEtLegumePileList);
        _MarcheDeFruitEtLegumePile.GetComponent<Pile>().costOfCardsInPile = 2;

        _MinePile = Instantiate(_MinePile);
        _PileList.Add(_MinePile);
        List<GameObject> _MinePileList = new List<GameObject>();
        for (int i = 0; i < _nbMine; i++)
        {
            _MinePileList.Add(_Mine);
        }
        _MinePile.GetComponent<Pile>().AddCardToPile(_MinePileList);
        _MinePile.GetComponent<Pile>().costOfCardsInPile = 6;

        _RestaurantPile = Instantiate(_RestaurantPile);
        _PileList.Add(_RestaurantPile);
        List<GameObject> _RestaurantPileList = new List<GameObject>();
        for (int i = 0; i < _nbRestaurant; i++)
        {
            _RestaurantPileList.Add(_Restaurant);
        }
        _RestaurantPile.GetComponent<Pile>().AddCardToPile(_RestaurantPileList);
        _RestaurantPile.GetComponent<Pile>().costOfCardsInPile = 3;

        _StadePile = Instantiate(_StadePile);
        _PileList.Add(_StadePile);
        List<GameObject> _StadePileList = new List<GameObject>();
        for (int i = 0; i < _nbStade; i++)
        {
            _StadePileList.Add(_Stade);
        }
        _StadePile.GetComponent<Pile>().AddCardToPile(_StadePileList);
        _StadePile.GetComponent<Pile>().costOfCardsInPile = 6;

        _SuperettePile = Instantiate(_SuperettePile);
        _PileList.Add(_SuperettePile);
        List<GameObject> _SuperettePileList = new List<GameObject>();
        for (int i = 0; i < _nbSuperette; i++)
        {
            _SuperettePileList.Add(_Superette);
        }
        _SuperettePile.GetComponent<Pile>().AddCardToPile(_SuperettePileList);
        _SuperettePile.GetComponent<Pile>().costOfCardsInPile = 2;

        _VergerPile = Instantiate(_VergerPile);
        _PileList.Add(_VergerPile);
        List<GameObject> _VergerPileList = new List<GameObject>();
        for (int i = 0; i < _nbVerger; i++)
        {
            _VergerPileList.Add(_Verger);
        }
        _VergerPile.GetComponent<Pile>().AddCardToPile(_VergerPileList);
        _VergerPile.GetComponent<Pile>().costOfCardsInPile = 3;

        _ForetPile = Instantiate(_ForetPile);
        _PileList.Add(_ForetPile);
        List<GameObject> _ForetPileList = new List<GameObject>();
        for (int i = 0; i < _nbForet; i++)
        {
            _ForetPileList.Add(_Foret);
        }
        _ForetPile.GetComponent<Pile>().AddCardToPile(_ForetPileList);
        _ForetPile.GetComponent<Pile>().costOfCardsInPile = 3;

    }

    public void RefreshScreen()
    {
        AffichageManager.instance.DelCard();
        foreach (GameObject player in _PlayerListReel)
        {
            AffichageManager.instance.RefreshPile(_PileList);
            AffichageManager.instance.RefreshPiece(player.GetComponent<Player>().Gold, player.GetComponent<Player>()._intPlayer);
            AffichageManager.instance.RefreshHand(player.GetComponent<Player>().cardsObject, player.GetComponent<Player>()._intPlayer, playerTurn);
            AffichageManager.instance.RefreshMonuments(player.GetComponent<Player>().etablissements, player.GetComponent<Player>()._intPlayer);
        }
    }

    public void IATurn()
    {
        int gold = playerTurn.GetComponent<Player>().Gold;
        
        if(Random.Range(0, 2) == 0)
        {
            Etablissement[] etablissements = FindObjectsOfType<Etablissement>();
            foreach (Etablissement etablissement in etablissements)
            {
                if (etablissement.costEtablissement <= gold && Random.Range(0, 2) == 0)
                {
                    etablissement.IAAchatEtablisement();
                    break;
                }
            }
        }
        else if(Random.Range(0, 5) == 0)
        {
            Pile[] piles = FindObjectsOfType<Pile>();
            foreach(Pile pile in piles)
            {
                if(pile.costOfCardsInPile <= gold && Random.Range(0, 2) == 0)
                {
                    pile.IAAchatPile();
                    break;
                }
            }
        }
        else if(Random.Range(0, 2) == 0)
        {
            Etablissement[] etablissements = FindObjectsOfType<Etablissement>();
            foreach (Etablissement etablissement in etablissements)
            {
                if (etablissement.costEtablissement <= gold && Random.Range(0, 2) == 0)
                {
                    etablissement.IAAchatEtablisement();
                    break;
                }
            }
        }
        else
        {
            Pile[] piles = FindObjectsOfType<Pile>();
            foreach (Pile pile in piles)
            {
                if (pile.costOfCardsInPile <= gold && Random.Range(0, 2) == 0)
                {
                    pile.IAAchatPile();
                    break;
                }
            }
        }
    }

}
