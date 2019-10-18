using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class MasterManager : MonoBehaviour
{
    [SerializeField] private Texture[] textures; // This contains all of the pictures
    [SerializeField] private RawImage rawImageComponent;
    [SerializeField] private int framesToWait = 10;
    [SerializeField] private string fileNameToSave;
    private int imageIndex = 0;

    void Awake()
    {
        // TODO: read into textures all of the pictures (textures)
    }

    void Start()
    {
        if(rawImageComponent == null)
        {
            Debug.LogWarning("RawImageComponent is null, but it shouldn't be!");
        }

        if(fileNameToSave == null)
        {
            Debug.LogWarning("name of the file to save is null, but it shouldn't be!");
        }
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(imageIndex > textures.Length - 1)
                imageIndex = 0; // Avoid IndexOutOfBoundsException
            StartCoroutine(WaitForXFrames(framesToWait));
        }

    }

    private IEnumerator WaitForXFrames(int x)
    {
        ShowImage();
        string startTime = DateTime.Now.ToString("HH:mm:ss.fff");
        while(x > 0)
        {
            x--;
            yield return null;
        }
        HideImage();
        string endTime = DateTime.Now.ToString("HH:mm:ss.fff");
        Logger.LogToFile(fileNameToSave, textures[imageIndex].name, startTime, endTime, framesToWait);
        imageIndex++;
    }

    private void ShowImage()
    {
        rawImageComponent.texture = textures[imageIndex];
        rawImageComponent.enabled = true;
    }

    private void HideImage()
    {
        rawImageComponent.enabled = false;
    }
}
