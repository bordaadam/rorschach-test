using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MazeManager : MonoBehaviour
{
    [SerializeField] private List<Light> lights;


    private void Update() 
    {
        if(Input.GetAxis("Mouse ScrollWheel") < 0f) 
        {
            for(int i = 0; i < lights.Count; i++)
            {
                lights[i].intensity -= 0.05f;
            }
        } 
        else if(Input.GetAxis("Mouse ScrollWheel") > 0f) 
        {
            for(int i = 0; i < lights.Count; i++)
            {
                lights[i].intensity += 0.05f;
            }
        }

        if(Input.GetKeyDown(KeyCode.X))
        {
            for(int i = 0; i < lights.Count; i++)
            {
                lights[i].GetComponent<LightGoesOut>().CanGoesOut = true;
            }
        }

    }

}
