using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    [SerializeField] private PlayerMovement _movement;

    [SerializeField] private Ragdoll _ragdoll;

    private void Update()
    {
        _animator.SetFloat("MovementSpeed", _movement.Velocity.z);
        _animator.SetBool("IsGrounded", _movement.IsGrounded);
    }

    private void OnEnable()
    {
        _movement.Jumped += OnJumped;
    }

    private void OnDisable()
    {
        _movement.Jumped -= OnJumped;

    }

    private void OnJumped()
    {
        _animator.SetTrigger("Jump");
    }

    public void OnDied(Collision collision)
    {
        _ragdoll.ActivevateRagdoll();
        _ragdoll.AddExpolisonForce(10,collision.GetContact(0).point,5);
    }
}