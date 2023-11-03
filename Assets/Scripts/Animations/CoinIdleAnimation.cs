using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CoinIdleAnimation : MonoBehaviour
{
    void Start()
    {
        transform.DOLocalMoveY(2f, 1f)
            .SetLoops(-1, LoopType.Yoyo)
            .SetDelay((transform.position.z % 2) * 0.5f);

        transform.DORotate(Vector3.up * 360, 2f, RotateMode.WorldAxisAdd)
            .SetLoops(-1)
            .SetEase(Ease.Linear);
    }

    private void OnDestroy()
    {
        transform.DOKill();
    }
}