using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEditor;
using System.Text;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    static public Game instance;

    private void Awake()
    {
        if(instance != null)
        {
            Debug.Log("Il y a plus d'une Instance de Game dans la scene");
            return;
        }
        instance = this;
    }

    //Gestion des joueurs
    List<GameObject> _PlayersList;
    [SerializeField] GameObject PlayerPrefab;
    [SerializeField] GameObject IAPrefabs;
    public GameObject playerTurn;
    [SerializeField] List<GameObject> _PlayerListReel;
    [SerializeField] int _intPlayerTurn;
    [SerializeField] bool _finTour;

    [SerializeField] int nbJoueur;

    [SerializeField] Gare gare;
    [SerializeField] GameObject _TwoDice;
    [SerializeField] GameObject _OneDice;
    [SerializeField] GameObject _EndTurn;

    [SerializeField] GameObject _WinPanel;
    [SerializeField] Text _WinText;




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

        for(int i = 0; i < nbJoueur; i++)
        {
            _PlayersList.Add(PlayerPrefab);
        }

        for(int i = 0; i < _PlayersList.Count; i++)
        {
            _PlayerListReel.Add(Instantiate(_PlayersList[i]));
            _PlayerListReel[i].name = "Player " + (i + 1);
        }

        foreach (GameObject player in _PlayerListReel)
        {
            AffichageManager.instance.RefreshHand(player.GetComponent<Player>().cardsObject);
        }

        _intPlayerTurn = 0;

        _WinPanel.SetActive(false);
        PrepareTurn();
    }

    public void PrepareTurn()
    {
        if (_finTour)
        {
            _finTour = false;
            if (_intPlayerTurn >= _PlayerListReel.Count)
            {
                _intPlayerTurn = 0;
            }

            playerTurn = _PlayerListReel[_intPlayerTurn];

            Player _PlayerListReelScript = playerTurn.GetComponent<Player>();

            DiceManager.instance.secondDice = false;
            _EndTurn.SetActive(false);
            _OneDice.SetActive(true);
            _TwoDice.SetActive(false);
            foreach (Etablissement etablissement in _PlayerListReelScript.etablissements)
            {
                if (etablissement.GetType() == gare.GetType())
                {
                    DiceManager.instance.secondDice = true;
                    _TwoDice.SetActive(true);
                }
            }
            _intPlayerTurn++;
        }
    }

    public void TurnWithOneDice()
    {
        PlayOneTurn(playerTurn);
        _OneDice.SetActive(false);
        _TwoDice.SetActive(false);
        _EndTurn.SetActive(true);
    }
    public void TurnWithTwoDice()
    {
        DiceManager.instance.playerChoiceDice = true;
        PlayOneTurn(playerTurn);
        _OneDice.SetActive(false);
        _TwoDice.SetActive(false);
        _EndTurn.SetActive(true);
    }

    public void FindeTour()
    {
        if (!_finTour)
        {
            AnimateRollDice();
            _finTour = true;
            PrepareTurn();
        }
    }

    public void PlayOneTurn(GameObject player)
    {
        Debug.Log("Tour Player : " + player);
        ResolutionActionTour(DiceManager.instance.RollAllDices(), playerTurn);

        if (CheckWin(player))
        {
            Debug.Log("Win : " + player);
            _WinPanel.SetActive(true);
            _WinText.text = player + " � Gagn� la Parti";
        }

        foreach (GameObject _player in _PlayerListReel)
        {
            AffichageManager.instance.RefreshHand(_player.GetComponent<Player>().cardsObject);
        }

    }


    public bool CheckWin(GameObject player)
    {
        bool _win = false;
        int win = 0;
        Player p = player.GetComponent<Player>();
        
        foreach(Etablissement etablissement in p.etablissements)
        {
            win++;
        }

        if(win >= 4)
            _win = true;

        return _win;
    }

    public void ResolutionActionTour(int result, GameObject playerTurn)
    {
        Debug.Log("Resolution Action Tour");
        foreach(GameObject p in _PlayerListReel)
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

        foreach(Player player in allPlayer)
        {
            if(player != p)
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

}
