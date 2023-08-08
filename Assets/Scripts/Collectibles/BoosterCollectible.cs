using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoosterCollectible : Collectable
{
    [SerializeField] private Booster _booster;

    protected override void OnCollected(GameObject collectedBy)
    {
        if(collectedBy.TryGetComponent<BoosterConteiner>(out BoosterConteiner conteiner))
        {
            conteiner.AddBoster(_booster);
        }
    }
}
