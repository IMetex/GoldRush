using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Boosters/Magnet")]
public class MagnetBooster : Booster
{
    [SerializeField, Tooltip("How far should the magnet pull the golds.")] 
    private float _radius = 10;
    public override void OnAdded(BoosterContanier container)
    {
        var attactor = container.gameObject.AddComponent<MagnetAttactor>();
        attactor.Radius = _radius; 
    }


    public override void OnRemoved(BoosterContanier container)
    {
        Destroy(container.GetComponent<MagnetAttactor>());
    }

}
