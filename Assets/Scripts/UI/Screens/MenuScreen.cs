using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuScreen : MonoBehaviour
{
    [SerializeField] private Button _playBtn;
    private void OnEnable()
    {
        _playBtn.onClick.AddListener(OnPlayButtonClicked);

    }
    private void OnDisable()
    {
        _playBtn.onClick.RemoveListener(OnPlayButtonClicked);
    }

    private void OnPlayButtonClicked()
    {
        GameInstance.Instance.StartGame();

    }
}
