using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class WinScreen : MonoBehaviour
{
    [SerializeField] private Button _nextLevelBtn;
    [SerializeField] private RectTransform _titleContainer;
    [SerializeField] private CanvasGroup _canvasGroup;

    private void OnEnable()
    {
        _nextLevelBtn.onClick.AddListener(OnNextLevelButtonPress);
        WinScreenAnimation();
    }

    private void OnDisable()
    {
        _titleContainer.DOComplete();
        _nextLevelBtn.onClick.RemoveListener(OnNextLevelButtonPress);
    }

    private void OnNextLevelButtonPress()
    {
        GameInstance.Instance.LoadCurrentLevel();
    }

    public void WinScreenAnimation()
    {
        var defaultSizeDelta = _titleContainer.sizeDelta;

        _titleContainer.DOSizeDelta(defaultSizeDelta, 0.4f)
            .From(new Vector2(335, defaultSizeDelta.y));
        
        _titleContainer.DOLocalMoveY(_titleContainer.transform.localPosition.y, 0.2f)
            .From(_titleContainer.transform.position.y - 100);
        
        _canvasGroup.DOFade(1, 0.2f).From(0);
    }
}