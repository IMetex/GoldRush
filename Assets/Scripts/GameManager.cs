using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;

    public static GameManager Instance
    {
        get
        {
            if (!_instance)
                _instance = FindObjectOfType<GameManager>();

            return _instance;
        }
    }

    private void Awake()
    {
        if (_instance && _instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }

    }

    public void Win()
    {
        SceneManager.LoadScene(0);
        EndGame();
    }

    public void Lose()
    {
        SceneManager.LoadScene(0);
        EndGame();
        GameLost?.Invoke(); 
    }

    public event Action<int> GoldChanged;

    public event Action GameStarted;

    public event Action GameEnded;

    public event Action GameLost;    

    private int _gold;
    public int Gold
    {
        get => _gold;
        set
        {
            _gold = value;
            GoldChanged?.Invoke(_gold);
        }
    }

    public bool IsGameStarted { get; private set; }

    public void StartGame()
    {
        IsGameStarted = true;
        GameStarted?.Invoke();
    }

    public void EndGame()
    {
        IsGameStarted = false;
        GameEnded?.Invoke();
    }
}
