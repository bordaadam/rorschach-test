using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadMaze : MonoBehaviour
{


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.V))
        {
            SceneManager.LoadScene(2);
        } 
    }
}
