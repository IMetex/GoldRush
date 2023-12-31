using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIPageController : MonoBehaviour
{
    [SerializeField] private MenuScreen _menuPage;
    [SerializeField] private GameObject _gamePage;
    [SerializeField] private GameObject _winPage;
    [SerializeField] private GameObject _losePage;

 void Start()
    {
        _menuPage.Open();

    }
  
    private void OnEnable()
    {
        GameInstance.Instance.GameStarted += OnGameStarted;
        GameInstance.Instance.Won += OnGameWon;
        GameInstance.Instance.Lost += OnGameLost;
    }

    private void OnDisable()
    {
        GameInstance.Instance.GameStarted -= OnGameStarted;
        GameInstance.Instance.Won -= OnGameWon;
        GameInstance.Instance.Lost -= OnGameLost;
    }

    private void OnGameStarted()
    {
        _menuPage.Close();
        _gamePage.SetActive(true);

    }

    private void OnGameWon()
    {
        _gamePage.SetActive(false);
        _winPage.SetActive(true);
    }

    private void OnGameLost()
    {
        _gamePage.SetActive(false);
        _losePage.SetActive(true);

    }
}
