using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DontDestroyOnLoad : MonoBehaviour
{
    public void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("DontDestroy");

        if(objs.Length > 1)
        {
            Destroy(this.gameObject);
        }
        foreach(GameObject obj in objs)
        {
            DontDestroyOnLoad(obj);
        }
    }
}
