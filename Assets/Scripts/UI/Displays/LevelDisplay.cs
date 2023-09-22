using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class LevelDisplay : MonoBehaviour
{

    [SerializeField] private TMP_Text _valueText;

    private void OnEnable()
    {
        GameInstance.Instance.LevelChanged += OnLevelChanged;
        UpdateUI();
    }

    private void OnDisable()
    {
        GameInstance.Instance.LevelChanged -= OnLevelChanged;
    }
    private void OnLevelChanged(int newLevel)
    {
        UpdateUI(newLevel);
    }

    private void UpdateUI(int value)
    {
        _valueText.text = "Level" + (value + 1);
    }
    private void UpdateUI()
    {
        UpdateUI(GameInstance.Instance.Level);
    }

   

}


