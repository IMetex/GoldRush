using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Speed Values")]
    [SerializeField] private float _forwardSpeed;
    [SerializeField] private float _horizontalSpeed;

    [Header("Jump Value")]
    [SerializeField] private float _jumpPower;

    public float JumpPower
    {
        get => _jumpPower;
        set => _jumpPower = value;
    }

    [Header("Horizontal Distance Value")]
    [SerializeField] private float _maxHorizontalDistance;

    private Rigidbody _rigidbody;
    private Vector3 _velocity = new(); // or new Vector3();
    private bool _isGrounded;


    private void Awake()
    {
        GetReferances();
    }
    private void GetReferances()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (!GameInstance.Instance.IsGameStarted)
        {
            _velocity = Vector3.zero;
            return;
        }

        MoveInput();
        Jump();
    }

    private void FixedUpdate()
    {
        ClampXPosition();
        _rigidbody.velocity = _velocity;
        GroundCheck();
    }

    private void MoveInput()
    {
        _velocity.x = Input.GetAxis("Horizontal") * _horizontalSpeed; // player left and right motion input
        _velocity.y = _rigidbody.velocity.y;
        _velocity.z = _forwardSpeed; // player forward movement
    }
    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _isGrounded)
        {
            _velocity.y = _jumpPower;
            //_rigidbody.AddForce(Vector3.up * _jumpPower, ForceMode.Impulse);
            _isGrounded = false;
        }
    }

    private void ClampXPosition()
    {
        if (Mathf.Abs(_rigidbody.position.x) > _maxHorizontalDistance)
        {
            var clampedPosition = _rigidbody.position;
            clampedPosition.x = Mathf.Clamp(clampedPosition.x, -_maxHorizontalDistance, _maxHorizontalDistance);

            _rigidbody.position = clampedPosition;
        }
    }
    private void GroundCheck()
    {
        _isGrounded = Physics.Raycast(_rigidbody.position, Vector3.down, 1.05f);
        Debug.DrawRay(_rigidbody.position, Vector3.down * 1.05f, Color.red);
    }
}
