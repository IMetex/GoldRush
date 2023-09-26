using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Collectible : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.attachedRigidbody.CompareTag("Player"))
        {
            OnCollected(other.gameObject);
            //Destroy(gameObject);
            gameObject.SetActive(false);
        }
    }
    protected abstract void OnCollected(GameObject collectedBy);

    // protected virtual void OnCollectedVirtual() {}
  


}
