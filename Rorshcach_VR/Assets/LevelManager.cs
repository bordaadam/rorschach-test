﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftControl))
        {
            SceneManager.LoadScene(0);
        } 
        else if(Input.GetKeyDown(KeyCode.RightControl))
        {
            SceneManager.LoadScene(1);
        }
    }
}
