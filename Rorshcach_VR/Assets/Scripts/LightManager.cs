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
    [SerializeField] private Material tmpMat;
    private AudioSource birdsAudioSource;
    private float decider = 1.5f;
    [SerializeField] private GameObject rain;
    [SerializeField] private DayState dayState;

    private enum DayState {Sunny, BetweenSunnyAndNight, Night, BetweenNightAndRainy, Rainy}
    private float b1 = 1.15f, b2 = 0.6f, b3 = 0.2f, b4 = -0.5f;

    void Start()
    {
        light = GameObject.FindGameObjectWithTag("Light").GetComponent<Light>();
        skybox = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Skybox>();
        birdsAudioSource =  GameObject.FindGameObjectWithTag("Birds").GetComponent<AudioSource>();
        lightIntensity = light.intensity;
        dayColor = light.color;
        dayState = DayState.Sunny;
    }

    void Update()
    {
        if(Input.GetAxis("Mouse ScrollWheel") > 0f) 
        {
            decider += 0.05f;

            switch(dayState) {

                case DayState.Sunny:
                    light.intensity += 0.05f;
                    break;

                case DayState.Rainy:
                light.intensity += 0.05f;
                    if(decider > b4) {
                        dayState = DayState.BetweenNightAndRainy;
                        skybox.material = tmpMat;
                        birdsAudioSource.enabled = true;
                        light.color = cloudyColor;
                        rain.SetActive(false);
                    }
                    break;

                case DayState.BetweenNightAndRainy:
                    light.intensity -= 0.05f;
                    if(decider > b3) {
                        dayState = DayState.Night;
                        skybox.material = nightMat;
                        light.color = nightColor;
                        birdsAudioSource.enabled = false;
                    }
                    break;

                case DayState.Night:
                    light.intensity += 0.05f;
                    if(decider > b2) {
                        dayState = DayState.BetweenSunnyAndNight;
                        skybox.material = tmpMat;
                        light.color = cloudyColor;
                    }
                    break;

                case DayState.BetweenSunnyAndNight:
                    light.intensity += 0.05f;
                    if(decider > b1) {
                        dayState = DayState.Sunny;
                        skybox.material = dayMat;
                        birdsAudioSource.enabled = true;
                        light.color = dayColor;
                    }
                    break;


            }

        } 
        else if(Input.GetAxis("Mouse ScrollWheel") < 0f) 
        {
            decider -= 0.05f;

            switch(dayState) {
                case DayState.Sunny:
                    light.intensity -= 0.05f;
                    if(decider < b1) {
                        dayState = DayState.BetweenSunnyAndNight;
                        skybox.material = tmpMat;
                        birdsAudioSource.enabled = true;
                        light.color = cloudyColor;
                    }
                    break;
                case DayState.BetweenSunnyAndNight:
                    light.intensity -= 0.05f;
                    if(decider < b2) {
                        dayState = DayState.Night;
                        skybox.material = nightMat;
                        birdsAudioSource.enabled = false;
                        light.color = nightColor;
                    }
                    break;

                case DayState.Night:
                    light.intensity += 0.05f;
                    if(decider < b3) {
                        dayState = DayState.BetweenNightAndRainy;
                        skybox.material = tmpMat;
                        light.color = cloudyColor;
                    }

                    break;

                case DayState.BetweenNightAndRainy:
                    if(decider < b4) {
                        rain.SetActive(true);
                        dayState = DayState.Rainy;
                        skybox.material = cloudyMat;
                    }
                    break;
            }
        }

        decider = Mathf.Clamp(decider, -1f, 1.5f);
        light.intensity = Mathf.Clamp(light.intensity, -1f, 1.5f);
    }

}
