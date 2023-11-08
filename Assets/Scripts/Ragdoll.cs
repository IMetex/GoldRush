using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ragdoll : MonoBehaviour
{
    [SerializeField] private Collider _characterCollider;
    [SerializeField] private Rigidbody _characterRigidbody;
    [SerializeField] private Animator animator;

    private Rigidbody[] _rigidbodies;
    private void Awake()
    {
        _rigidbodies = GetComponentsInChildren<Rigidbody>();
    }

    public void ActivevateRagdoll()
    {
        _characterCollider.enabled = false;
        _characterRigidbody.isKinematic = true;
        animator.enabled = false;
        
        foreach (var rb in _rigidbodies)
        {
            rb.isKinematic = false;
            if (rb.TryGetComponent<Collider>(out var col))
            {
                col.enabled = true;
            }
        }
    }

    public void AddExpolisonForce(float force,Vector3 pos,float radius)
    {
        foreach (var rb in _rigidbodies)
        {
            rb.AddExplosionForce(force,pos,radius,1,ForceMode.Impulse);
        }
    }
}