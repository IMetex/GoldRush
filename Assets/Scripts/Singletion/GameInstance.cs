using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameInstance : MonoBehaviour
{
    private static GameInstance _instance;
    public static GameInstance Instance
    {
        get
        {
            if (!_instance)
            {
                _instance = FindObjectOfType<GameInstance>();
            }

            return _instance;
        }
    }
    private void Awake()
    {
        if (_instance && _instance != this)
            Destroy(gameObject);
        else
            DontDestroyOnLoad(gameObject);
        //always keeps you on stage

        //_instance = this;
    }

    public bool IsGameStarted { get; private set; }


    // public int Gold { get; set; }
    // public int Level { get; set; }

    public event Action GameStarted;
    public event Action GameEnded;
    public event Action Won;
    public event Action Lost;
    public event Action<int> LevelChanged;
    public event Action<int> GoldChanged;

    private int _level;
    private int _gold;

    public int Level
    {
        get => _level;
        set
        {
            _level = value;
            LevelChanged?.Invoke(_level);
        }
    }
    public int Gold
    {
        get => _gold;
        set
        {
            _gold = value;
            GoldChanged?.Invoke(_gold);
        }
    }

    public void LoadCurrentLevel()
    {
        SceneManager.LoadScene(0);
    }
    public void RestartLevel()
    {
        SceneManager.LoadScene(0);
    }

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

    public void Win()
    {
        Level++;
        EndGame();
        Won?.Invoke();

    }

    public void Lose()
    {
        EndGame();
        Lost?.Invoke();

    }
}
