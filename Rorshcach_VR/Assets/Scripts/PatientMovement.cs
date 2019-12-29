using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Library.Utilities;

public class PatientMovement : MonoBehaviour
{

    [SerializeField] private float movementSpeed = 5f;
    [SerializeField] private float timeBetweenSteps = 0.5f;
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
        movement = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
        movement = movement.normalized * movementSpeed;
        transform.eulerAngles = new Vector3(0, 0, 0);
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

}
