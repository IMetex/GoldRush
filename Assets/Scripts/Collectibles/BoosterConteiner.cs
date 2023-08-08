using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoosterConteiner : MonoBehaviour
{
    private List<BoosterInstance> _activeBooster = new List<BoosterInstance>();
    public void AddBoster(Booster booster)
    {

    }

    public void RemoveBoster(Booster booster)
    {

    }

    public class BoosterInstance
    {
        public Booster Booster { get; set; }
        public float RemainingDuration { get; set; }

        public BoosterInstance(Booster booster)
        {
            Booster = booster;
            RemainingDuration = Booster.Duration;
        }
    }

}
