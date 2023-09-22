using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GoldDisplay : MonoBehaviour
{
    [SerializeField] private TMP_Text _valueText;

    private void OnEnable()
    {
        GameInstance.Instance.GoldChanged += OnGoldChanged;
        UpdateUI();
    }

    private void OnDisable()
    {
        GameInstance.Instance.GoldChanged -= OnGoldChanged;
    }
    private void OnGoldChanged(int newGold)
    {
        UpdateUI(newGold);
    }

    private void UpdateUI(int value)
    {
        _valueText.text = value.ToString();
    }
     private void UpdateUI()
    {
        UpdateUI(GameInstance.Instance.Gold);
    }

    // void Update()
    // {
    //     // _valueText.text = GameInstance.Instance.Gold.ToString();
    // }

}
