using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.rigidbody.CompareTag("Player"))
        {
            Debug.Log(collision.rigidbody.name);
        }
        else
        {
            collision.rigidbody.AddForce(Vector3.up*60,ForceMode.Impulse);
        }
        
    }
}
