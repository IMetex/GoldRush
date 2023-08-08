using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gold : Collectable
{
    protected override void OnCollected(GameObject collectedBy)
    {
        GameManager.Instance.Gold +=(int)( 1 * GameManager.Instance.GoldMultiplier);

    }
}
