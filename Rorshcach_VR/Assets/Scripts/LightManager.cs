using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightManager : MonoBehaviour
{
    private const float MIN_INTENSITY = 0.5f;
    private const float MAX_INTENSITY = 1.5f;
    private Skybox skybox;
    private Light light;
    [SerializeField] private float lightIntensity;
    [SerializeField] private Color dayColor;
    [SerializeField] private Color cloudyColor;
    [SerializeField] private Color nightColor;
    [SerializeField] private Material dayMat;
    [SerializeField] private Material cloudyMat;
    [SerializeField] private Material nightMat;
    private AudioSource birdsAudioSource;

    void Start()
    {
        light = GameObject.FindGameObjectWithTag("Light").GetComponent<Light>();
        skybox = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Skybox>();
        birdsAudioSource =  GameObject.FindGameObjectWithTag("Birds").GetComponent<AudioSource>();
        lightIntensity = light.intensity;
        dayColor = light.color;
    }

    void Update()
    {
        if(Input.GetAxis("Mouse ScrollWheel") > 0f) 
        {
            lightIntensity += 0.05f;
        } 
        else if(Input.GetAxis("Mouse ScrollWheel") < 0f) 
        {
            lightIntensity -= 0.05f;
        }

        //TODO: optimize this code snippet
        if(lightIntensity > 1.15) 
        {
            skybox.material = dayMat;
            light.color = dayColor;
            birdsAudioSource.enabled = true;
        }
        if(lightIntensity > 0.6 && lightIntensity < 1.15)
        {
            light.color = cloudyColor;
            skybox.material = cloudyMat;
            birdsAudioSource.enabled = false;
        }
        if(lightIntensity < 0.6) {
            skybox.material = nightMat;
            light.color = nightColor;
            birdsAudioSource.enabled = false;

        }

        lightIntensity = Mathf.Clamp(lightIntensity, MIN_INTENSITY, MAX_INTENSITY);
        light.intensity = lightIntensity;
    }

}
