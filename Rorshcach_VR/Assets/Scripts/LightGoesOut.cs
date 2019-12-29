using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightGoesOut : MonoBehaviour
{

    [SerializeField] private Light light;
    [SerializeField] private float min, max;
    [SerializeField] private AudioSource source;
    [SerializeField] private ParticleSystem particleSystem;

    private void OnTriggerEnter(Collider other) 
    {
        if(other.GetComponent<PatientMovement>())
        {
            source.Play();
            particleSystem.Play();
            StartCoroutine(Wait());
        }
    }


    IEnumerator Wait()
    {
        while(true)
        {
            yield return new WaitForSeconds(Random.Range(min, max));
            light.enabled = !light.enabled;
        }
    }
}
