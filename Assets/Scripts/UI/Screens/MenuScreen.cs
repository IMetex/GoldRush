using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class MenuScreen : MonoBehaviour
{
    [SerializeField] private Button _playBtn;

    [SerializeField] private CanvasGroup _canvasGroup;

    [SerializeField] private Transform _containerTransform;

    private void OnEnable()
    {
        _playBtn.onClick.AddListener(OnPlayButtonClicked);

        MenuAnimation();
    }

    private void OnDisable()
    {
        _playBtn.onClick.RemoveListener(OnPlayButtonClicked);
    }

    private void OnPlayButtonClicked()
    {
        GameInstance.Instance.StartGame();
    }

    public void Open()
    {
    }

    public void Close()
    {
        _canvasGroup.DOFade(0, 0.2f)
            .OnComplete(() => gameObject.SetActive(false));
    }

    private void MenuAnimation()
    {
        //Alpha value
        _canvasGroup.DOFade(1, 0.2f).From(0);
        _containerTransform.DOScale(1f, 0.2f).From(1.5f);
        _containerTransform.DOLocalMoveY(0, 0.2f).From(-250).SetEase(Ease.OutBack);
    }
}