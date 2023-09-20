using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Speed Settings")]
    [SerializeField] private float _forwardSpeed;
    [SerializeField] private float _horizontalSpeed;

    private Rigidbody _rigidbody;
    private Vector3 _velocity = new(); // or new Vector3();

    private void Awake()
    {
        GetReferances();
    }
    private void GetReferances()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void MoveInput()
    {
        _velocity.x = Input.GetAxis("Horizontal") * _horizontalSpeed; // player left and right motion input
        _velocity.y = _rigidbody.velocity.y;
        _velocity.z = _forwardSpeed; // player forward movement
    }
    private void Update()
    {
        MoveInput();

    }
    private void FixedUpdate()
    {
        _rigidbody.velocity = _velocity;
    }



}
