using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gold : Collectible
{
    protected override void OnCollected(GameObject collectedBy)
    {
        // TODO Increment player gold
        GameInstance.Instance.Gold += Mathf.RoundToInt(1 * GameInstance.Instance.GoldMultipler);
                                      //(int)

    }
}
