using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform camTarget;
    [SerializeField] private Vector3 dist;

    private void LateUpdate()
    {
        transform.position= camTarget.position + dist;
    }
        
}
