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

    private void OnEnable()
    {
        GameManager.Instance.GameStarted += OnGameStarted;
        GameManager.Instance.GameLost += OnGameLost;

    }
    private void OnDisable()
    {
        GameManager.Instance.GameStarted -= OnGameStarted;
        GameManager.Instance.GameLost -= OnGameLost;
    }

    private void OnGameStarted()
    {
        _menuScreen.SetActive(false);
        _gameScreen.SetActive(true);
    }
    private void OnGameLost()
    {
        _gameScreen.SetActive(false);
        _loseScreen.SetActive(true);

    }
}
