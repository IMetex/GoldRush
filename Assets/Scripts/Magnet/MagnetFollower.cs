using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnetFollower : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private float _speed = 8;
    public Transform Target
    {
        get => _target;
        set => _target = value;
    }

    private void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, _target.position, _speed * Time.deltaTime);

    }
}
