using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitManager : MonoBehaviour
{

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)) {
            Debug.Log("Exiting from application...");
            Application.Quit();
        }
    }
}
