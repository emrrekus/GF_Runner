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

    [SerializeField]private float _jumpPower;

    private bool _isGrounded;
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        velocity.z = _forwardSpeed;
        velocity.y = _rigidbody.velocity.y;
        velocity.x = Input.GetAxis("Horizontal") * _horizantolSpeed;

        if (Input.GetKeyDown(KeyCode.Space) && _isGrounded)
        {
            _rigidbody.AddForce(Vector3.up* _jumpPower,ForceMode.Impulse);
            _isGrounded = false;
        }
    }

    private void FixedUpdate()
    {
        _rigidbody.velocity = velocity;
        
        Debug.DrawRay(transform.position,Vector3.down * 1.05f);
        _isGrounded = Physics.Raycast(transform.position, Vector3.down, 1f);
        
    }
}