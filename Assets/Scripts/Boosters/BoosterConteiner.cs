using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoosterConteiner : MonoBehaviour
{
    private List<BoosterInstance> _activeBooster = new List<BoosterInstance>();
    public void AddBoster(Booster booster)
    {
        var boosterInstance = new BoosterInstance(booster);
        _activeBooster.Add(boosterInstance);
        booster.OnAdded(this);

    }

    public void RemoveBoster(Booster booster)
    {
        foreach (var instance in _activeBooster)
        {
            if (instance.Booster == booster)
            {
                instance.RemainingDuration = 0;
            }
        }
    }

    private void Update()
    {
        for (int i = _activeBooster.Count - 1; i >= 0; i--)
        {
            var instance = _activeBooster[i];
            instance.RemainingDuration -= Time.deltaTime;

            if (instance.RemainingDuration <= 0)
            {
                instance.Booster.OnRemoved(this);
                _activeBooster.RemoveAt(i);
            }
        }

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
