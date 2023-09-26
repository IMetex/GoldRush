using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Boosters/2xGold")]
public class DoubleGoldBooster : Booster
{
    public override void OnAdded(BoosterContanier container)
    {
        GameInstance.Instance.GoldMultipler += 2;

    }

    public override void OnRemoved(BoosterContanier container)
    {
        GameInstance.Instance.GoldMultipler += 1;

    }


}
