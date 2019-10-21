using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class MasterManager : MonoBehaviour
{
    //[SerializeField] private Texture2D[] textures; // This contains all of the pictures
    [SerializeField] private List<Texture2D> textures;
    [SerializeField] private RawImage rawImageComponent;
    [SerializeField] private int framesToWait = 10;
    [SerializeField] private string fileNameToSave;
    private int imageIndex = 0;

    public string cmdInfo = "";

    void Awake()
    {
        // TODO: read into textures all of the pictures (textures)
        textures = Reader.GetImagesFromDirectory("D:\\kepek");
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

        string[] args = Environment.GetCommandLineArgs();
        int i = 0;
        foreach(var arg in args)
        {
            cmdInfo += i.ToString() + ": " + arg + "\n";
            i++;
        }
    }

    void OnGUI()
     {
         Rect r = new Rect(5,5, 800, 500);
         GUI.Label(r, cmdInfo);
     }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            imageIndex = imageIndex % textures.Count; // to avoid indexing exception
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
        //Logger.LogToFile(fileNameToSave, textures[imageIndex].name, startTime, endTime, framesToWait);
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
