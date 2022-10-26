using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Etablissement : MonoBehaviour
{
    int costEtablissement;

    public Etablissement(int costEtablissement)
    {
        this.costEtablissement = costEtablissement;
    }
}
