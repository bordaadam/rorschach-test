using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightGoesOut : MonoBehaviour
{

    [SerializeField] private Light light;
    [SerializeField] private float min, max;

    private void OnTriggerEnter(Collider other) 
    {
        if(other.GetComponent<PatientMovement>())
        {
            StartCoroutine(Wait(Random.Range(min, max)));
        }
    }


    IEnumerator Wait(float t)
    {
        while(true)
        {
            yield return new WaitForSeconds(t);
            light.enabled = !light.enabled;
        }
    }
}
