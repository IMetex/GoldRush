using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gold : Collectable
{
    protected override void OnCollected()
    {
        GameManager.Instance.Gold++;

    }
}
