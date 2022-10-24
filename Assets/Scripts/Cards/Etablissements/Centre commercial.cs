using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Centrecommercial : Etablissement
{
    readonly string name;
    readonly int costEtablissement;

    public Centrecommercial()
    {
        this.name = "Centre commercial";
        this.costEtablissement = 10;
    }
}
