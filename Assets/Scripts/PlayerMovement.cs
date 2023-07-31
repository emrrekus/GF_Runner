using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _forwardSpeed;

    [SerializeField] private float _horizantolSpeed;
    [SerializeField] private Rigidbody _rigidbody;
    private Vector3 velocity = new Vector3();

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        velocity.z = _forwardSpeed;
        velocity.x = Input.GetAxis("Horizontal") * _horizantolSpeed;
    }

    private void FixedUpdate()
    {
        _rigidbody.velocity = velocity;
    }
}