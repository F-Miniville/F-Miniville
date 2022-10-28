using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioForButton : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    bool ok = true;
    public void OnMouseOver()
    {
        if (ok)
        {
            ok = false;
            Debug.Log("Passe sur un bouton");
            audioSource.Play();
        }
    }
    public void OnMouseExit()
    {
        ok = true;
    }

}
