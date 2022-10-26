using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parcdattraction : Etablissement
{
    readonly int costEtablissement;

    public Parcdattraction(int costEtablissement) : base(costEtablissement)
    {
        this.costEtablissement = costEtablissement;
    }
}
