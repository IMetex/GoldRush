using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Booster : ScriptableObject
{
   [SerializeField] private Sprite _icon;

   [SerializeField] private float _duration;

   public float Duration => _duration;

   public abstract void OnAdded(BoosterContanier container);
   public abstract void OnRemoved(BoosterContanier container);


}
