using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Library.Utilities;

public class PatientMovement : MonoBehaviour
{

    [SerializeField] private float movementSpeed = 5f;
    [SerializeField] private float timeBetweenSteps = 0.5f;
    [SerializeField] private float rotateSpeed;
    private bool canPlay = true;
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
        HandleMovement();
        HandleRotation();
        
        if(movement != Vector3.zero && !audioSource.isPlaying && canPlay)
        {
            StartCoroutine(WaitSound(timeBetweenSteps));
            audioSource.Play();
        }

    }

    IEnumerator WaitSound(float t) 
    {
        canPlay = false;
        yield return new WaitForSeconds(t);
        canPlay = true;
    }

    void FixedUpdate() 
    {
        rigidbody.velocity = movement;
    }

    void HandleMovement()
    {
        movement = Vector3.zero;
        if(Input.GetKey(KeyCode.W))
        {
            movement = transform.forward;
            movement = movement.normalized * movementSpeed;
        }
    }

    void HandleRotation()
    {
        if(Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0, -rotateSpeed * Time.deltaTime, 0), Space.Self);
        }

        if(Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0, rotateSpeed * Time.deltaTime, 0), Space.Self);
        }
    }

}
