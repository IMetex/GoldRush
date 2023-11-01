using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Gold : Collectible
{
    [SerializeField] private Transform _graphics;
    [SerializeField] private ParticleSystem _collectPartical;


    protected override void OnCollected(GameObject collectedBy)
    {
        // TODO Increment player gold   //(int)
        GameInstance.Instance.Gold += Mathf.RoundToInt(1 * GameInstance.Instance.GoldMultipler);

        _graphics.DOKill();
        _graphics.SetParent(null);
        
        _graphics.DOMoveY(_graphics.position.y + 8f, .2f)
            .OnComplete(() => Destroy(_graphics.gameObject));

        _graphics.DOScale(0.5f, 0.2f);

        Instantiate(_collectPartical, transform.position, Quaternion.identity);

    }
}