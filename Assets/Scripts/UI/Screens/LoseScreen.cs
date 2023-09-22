using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoseScreen : MonoBehaviour
{
    [SerializeField] private Button _restartLevellBtn;
    private void OnEnable()
    {
        _restartLevellBtn.onClick.AddListener(OnRestartLevelButtonPress);

    }
    private void OnDisable()
    {
        _restartLevellBtn.onClick.RemoveListener(OnRestartLevelButtonPress);
    }

    private void OnRestartLevelButtonPress()
    {
        GameInstance.Instance.RestartLevel();

    }
}
