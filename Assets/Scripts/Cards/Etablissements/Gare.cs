using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gare : Etablissement
{
    readonly string name;
    readonly int costEtablissement;

    public Gare()
    {
        this.name = "Gare";
        this.costEtablissement = 4;
    }
}
