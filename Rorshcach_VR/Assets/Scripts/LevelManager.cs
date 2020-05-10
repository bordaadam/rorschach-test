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
            SceneManager.LoadScene(1);
        }
    }
}
