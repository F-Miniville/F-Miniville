using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioMenu : MonoBehaviour
{
    static public audioMenu instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.Log("Il y a plus d'une Instance de DiceManager dans la scene");
            Destroy(this.gameObject);
            return;
        }
        instance = this;
    }
}
