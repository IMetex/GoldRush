using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gold : Collectible
{
    protected override void OnCollected()
    {
        // TODO Increment player gold
        GameInstance.Instance.Gold++;
        
    }
}
