using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gare : Etablissement
{
    readonly int costEtablissement;

    public Gare(int costEtablissement) : base(costEtablissement)
    {
        this.costEtablissement = costEtablissement;
    }
}
