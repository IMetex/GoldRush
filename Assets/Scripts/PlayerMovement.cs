using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement Values")]

    [SerializeField] private float _forwardSpeed;

    [SerializeField] private float _horizontalSpeed;

    [SerializeField] private float _jumpPower;


    private float _maxHorizontalDistance = 4.3f;

    private Rigidbody _rb;


    private Vector3 _velocity = new Vector3();
    public Vector3 Velocity => _rb.velocity;


    private bool _isGrounded = false;
    private bool _hasStarted = false;


    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (!GameManager.Instance.IsGameStarted)
            return;

        _velocity.z = _forwardSpeed; // player foward 
        _velocity.y = _rb.velocity.y;
        _velocity.x = Input.GetAxis("Horizontal") * _horizontalSpeed; // player left and right X position


        if (Input.GetKeyDown(KeyCode.Space) && _isGrounded)
        {
            _velocity.y = _jumpPower;
            //_rb.AddForce(Vector3.up * _jumpPower, ForceMode.Impulse);
            _isGrounded = false;
        }
    }

    private void FixedUpdate()
    {
        if (Mathf.Abs(_rb.position.x) > _maxHorizontalDistance)
        {
            var clampPosition = _rb.position;
            clampPosition.x = Mathf.Clamp(clampPosition.x, -_maxHorizontalDistance, _maxHorizontalDistance);

            _rb.position = clampPosition;
        }
        _rb.velocity = _velocity;

        Debug.DrawRay(_rb.position + Vector3.up, Vector3.down * 1.55f, Color.red);
        _isGrounded = Physics.Raycast(_rb.position + Vector3.up, Vector3.down, 1.55f);

    }

    public void PlayerRotation()
    {
         transform.rotation = Quaternion.identity;
    }
}
