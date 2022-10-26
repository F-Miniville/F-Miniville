using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tourradio : Etablissement
{
    readonly int costEtablissement;

    public Tourradio(int costEtablissement) : base(costEtablissement)
    {
        this.costEtablissement = costEtablissement;
    }
}
