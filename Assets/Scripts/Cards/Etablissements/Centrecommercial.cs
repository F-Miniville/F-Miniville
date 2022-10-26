using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Centrecommercial : Etablissement
{
    readonly int costEtablissement;

    public Centrecommercial(int costEtablissement) : base(costEtablissement)
    {
        this.costEtablissement = costEtablissement;
    }
}
