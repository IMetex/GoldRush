using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoosterCollectible : Collectible
{
    [SerializeField] private Booster _booster;

    protected override void OnCollected(GameObject collectedBy)
    {
        //collectedBy.GetComponent<BoosterContainer>();

        if (collectedBy.TryGetComponent<BoosterContanier>(out BoosterContanier container))
        {
            container.AddBooster(_booster);
        }


    }
}
