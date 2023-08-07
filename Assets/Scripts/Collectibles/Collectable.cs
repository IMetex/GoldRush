using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Collectable : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if(other.attachedRigidbody.CompareTag("Player"))
        {
            OnCollected();
            gameObject.SetActive(false);
        }

    }

    protected abstract void OnCollected();

}
