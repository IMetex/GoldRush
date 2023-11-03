using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class LoseScreen : MonoBehaviour
{
    [SerializeField] private Button _restartLevellBtn;
    [SerializeField] private Transform _containerTransform;
    [SerializeField] private CanvasGroup _canvasGroup;

    private void OnEnable()
    {
        _restartLevellBtn.onClick.AddListener(OnRestartLevelButtonPress);
        LoseScreenAnimation();
    }

    private void OnDisable()
    {
        _restartLevellBtn.onClick.RemoveListener(OnRestartLevelButtonPress);
    }

    private void OnRestartLevelButtonPress()
    {
        GameInstance.Instance.RestartLevel();
    }

    private void LoseScreenAnimation()
    {
        _canvasGroup.DOFade(1, 0.2f).From(0);
        _containerTransform.DOLocalMoveY(0, 0.8f)
            .From(-300).SetEase(Ease.OutBack);
    }
}