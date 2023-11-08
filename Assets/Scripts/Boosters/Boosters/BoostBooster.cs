using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Boosters/Boost")]
public class BoostBooster : Booster
{
    [SerializeField] private float _multiplier = 1.2f;
    public override void OnAdded(BoosterContanier container)
    {
        //if (container.TryGetComponent<PlayerMovement>(out var PlayerMovement playerMovement))
        //if (container.TryGetComponent<PlayerMovement>(out var playerMovement))
        // make or,
        if (container.TryGetComponent(out PlayerMovement playerMovement))
        {
            playerMovement.JumpPower *= _multiplier;

        }
    }
    public override void OnRemoved(BoosterContanier container)
    {
        if (container.TryGetComponent(out PlayerMovement playerMovement))
        {
            playerMovement.JumpPower /= _multiplier;

        }

    }
}
