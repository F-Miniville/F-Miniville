using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tourradio : Etablissement
{
    readonly string name;
    readonly int costEtablissement;

    public Tourradio()
    {
        this.name = "Tour radio";
        this.costEtablissement = 22;
    }
}
