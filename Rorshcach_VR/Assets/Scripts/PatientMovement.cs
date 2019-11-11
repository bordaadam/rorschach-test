﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Library.Utilities;

public class PatientMovement : MonoBehaviour
{

    [SerializeField] private float movementSpeed = 5f;
    private AudioSource audioSource;

    private Rigidbody rigidbody;
    private Vector3 movement;

    void Awake() 
    {
        rigidbody = gameObject.GetRequiredComponent<Rigidbody>();
        audioSource = gameObject.GetRequiredComponent<AudioSource>();
    }

    void Update()
    {
        movement = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
        movement = movement.normalized * movementSpeed;
        transform.eulerAngles = new Vector3(0, 0, 0);
        if(movement != Vector3.zero && !audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }

    void FixedUpdate() 
    {
        rigidbody.velocity = movement;
    }

}
