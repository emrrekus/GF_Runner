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
            var hitNormal = collision.GetContact(0).normal;
            var hitDot = Vector3.Dot(hitNormal, Vector3.forward);
          
            
            if (hitDot > 0.99f)
                GameInstance.Instance.Lose();
        }
    }
}