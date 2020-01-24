using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightGoesOut : MonoBehaviour
{

    [SerializeField] private float min, max;
    [SerializeField] private ParticleSystem particleSystem;
    private AudioSource source;
    private Light light;
    private bool _canGoesOut = false;

    public bool CanGoesOut 
    {
        set { _canGoesOut = value; }
        private get { return _canGoesOut; }
    }

    private void Start() {
        light = GetComponent<Light>();
        source = GetComponent<AudioSource>();
        particleSystem.gameObject.SetActive(false);
    }   

    private void OnTriggerEnter(Collider other) 
    {
        if(other.GetComponent<PatientMovement>() && _canGoesOut)
        {
            source.Play();
            particleSystem.gameObject.SetActive(true);
            particleSystem.Play();
            StartCoroutine(Wait());
            Destroy(GetComponent<BoxCollider>());
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
