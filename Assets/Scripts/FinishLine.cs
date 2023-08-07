using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    private void OnCollisionEnter(Collision col)
    {
        if(col.rigidbody.CompareTag("Player"))
        {
            GameManager.Instance.Win();
        } 
    }
}
