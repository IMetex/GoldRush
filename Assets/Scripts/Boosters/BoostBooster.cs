using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Booster/Boost")]
public class BoostBooster : Booster
{
    public override void OnAdded(BoosterConteiner contanier)
    {
        if (contanier.TryGetComponent(out PlayerMovement playerMovement))
        {
            playerMovement.JumpPower *= 2f;
        }

    }
    public override void OnRemoved(BoosterConteiner contanier)
    {
        if (contanier.TryGetComponent(out PlayerMovement playerMovement))
        {
            playerMovement.JumpPower /= 2f;
        }


    }

}
