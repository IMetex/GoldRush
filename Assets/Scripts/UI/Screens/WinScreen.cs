using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinScreen : MonoBehaviour
{
    [SerializeField] private Button _nextLevelBtn;
    private void OnEnable()
    {
        _nextLevelBtn.onClick.AddListener(OnNextLevelButtonPress);

    }
    private void OnDisable()
    {
        _nextLevelBtn.onClick.RemoveListener(OnNextLevelButtonPress);
    }

    private void OnNextLevelButtonPress()
    {
        GameInstance.Instance.LoadCurrentLevel();

    }
}

