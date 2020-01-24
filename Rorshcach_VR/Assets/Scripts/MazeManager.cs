using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MazeManager : MonoBehaviour
{
    [SerializeField] private List<Light> lights;
    private const float DEFAULT_INTENSITY = 1f;
    private const float HALF_INTENSITY = 0.5f;
    private const float FADE_TIME = 200f;


    private void Update() 
    {
        if(Input.GetKeyDown(KeyCode.C))
        {

            foreach(var l in lights)
            {
            StartCoroutine(FadeLight(l, DEFAULT_INTENSITY));
                
            }

        } 
        else if(Input.GetKeyDown(KeyCode.V)) 
        {

            foreach(var l in lights)
            {
            StartCoroutine(FadeLight(l, HALF_INTENSITY));
            }
        }
        else if(Input.GetKeyDown(KeyCode.B)) 
        {
            foreach(var l in lights)
            {
                l.GetComponent<LightGoesOut>().CanGoesOut = true;
            }
        }
        
    }

    IEnumerator FadeLight(Light light, float to)
    {
        var t = 0.0f;

        while(t < FADE_TIME)
        {
            t += Time.deltaTime;

            light.intensity = Mathf.Lerp(light.intensity, to, t / FADE_TIME);
            yield return 0;
        }
    }

}
