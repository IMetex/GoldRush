using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoosterDisplayContanier : MonoBehaviour
{
    [SerializeField] private BoosterContanier _boosterContanier;
    [SerializeField] private BoosterDisplay _boosterDisplayPrefab;
    [SerializeField] private Transform _content;

    private List<BoosterDisplay> _activeBoosterDisplays = new List<BoosterDisplay>();

    private void OnEnable()
    {
        _boosterContanier.BoosterAdded += OnBoosterAdded;
        _boosterContanier.BoosterRemoved += OnBoosterRemoved;

    }
    private void OnDisable()
    {
        _boosterContanier.BoosterAdded -= OnBoosterAdded;
        _boosterContanier.BoosterRemoved -= OnBoosterRemoved;

    }

    private void OnBoosterAdded(BoosterContanier.BoosterInstance instance)
    {
        var display = Instantiate(_boosterDisplayPrefab, _content);
        display.BoosterInstance = instance;
        _activeBoosterDisplays.Add(display);

    }

    private void OnBoosterRemoved(Booster booster)
    {
        for (int i = _activeBoosterDisplays.Count - 1; i >= 0; i--)
        {
            var display = _activeBoosterDisplays[i];
            if (display.BoosterInstance.Booster == booster)
            {
                Destroy(display.gameObject);
                _activeBoosterDisplays.RemoveAt(i); 
            }
        }

    }
}
