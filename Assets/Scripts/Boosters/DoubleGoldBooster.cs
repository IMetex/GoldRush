using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Booster/2x Gold")]
public class DoubleGoldBooster : Booster
{
    public override void OnAdded(BoosterConteiner contanier)
    {
        GameManager.Instance.GoldMultiplier = 2;

    }
    public override void OnRemoved(BoosterConteiner contanier)
    {
        GameManager.Instance.GoldMultiplier = 1;

    }
}
