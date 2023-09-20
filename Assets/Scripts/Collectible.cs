using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Collectible : MonoBehaviour
{
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.attachedRigidbody.CompareTag("Player"))
        {
            OnCollected();
        }
    }
    protected abstract void OnCollected();

    // protected virtual void OnCollectedVirtual() {}
  

}
