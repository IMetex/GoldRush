using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIPageController : MonoBehaviour
{
    [SerializeField] private GameObject _menuScreen;
    
    [SerializeField] private GameObject _gameScreen;

    [SerializeField] private GameObject _loseScreen;

    private void Start()
    {
        _menuScreen.SetActive(true);
        
    }
}
