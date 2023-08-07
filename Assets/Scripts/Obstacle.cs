using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private void OnCollisionEnter(Collision col)
    {
        if (col.rigidbody.CompareTag("Player"))
        {
            var hitNormal = col.GetContact(0).normal;
            var hitDot = Vector3.Dot(hitNormal, Vector3.forward);
            
            //Debug.Log("HitDot: " + hitDot);
            Debug.DrawRay(col.GetContact(0).point, hitNormal * 10, Color.red, 10);

            if (hitDot > 0.1f)
            {
                GameManager.Instance.Lose();
            }
        }
    }
}
