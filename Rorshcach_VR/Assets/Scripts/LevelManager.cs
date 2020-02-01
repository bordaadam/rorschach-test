using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) 
    {
        if(other.GetComponent<PatientMovement>())
        {
            SceneManager.LoadScene(0);
        }
    }

    private void Update() 
    {
        if(Input.GetKeyDown(KeyCode.V))
        {
            SceneManager.LoadScene(2); // maze With Objects
        }    
    }
}
