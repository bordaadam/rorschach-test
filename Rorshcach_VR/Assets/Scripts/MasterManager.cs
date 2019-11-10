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
    private int imageIndex = 0;
    
    [SerializeField] private int framesToWait = 10;
    private string folderPath;
    private string folderToLog;
    private string nameOfFile;
    private string patientInfo;

    public string cmdInfo = "";

    void Awake()
    {
        InitializeParams();
        //this.folderPath = "D:\\kepek";
        textures = Reader.GetImagesFromDirectory(folderPath);

    }

    void Start()
    {
        if(rawImageComponent == null)
        {
            Debug.LogWarning("RawImageComponent is null, but it shouldn't be!");
        }

        /* TESTING */
        string[] args = Environment.GetCommandLineArgs();
        int i = 0;
        foreach(var arg in args)
        {
            cmdInfo += i.ToString() + ": " + arg + "\n";
            i++;
        }
        /* TESTING */
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
        Logger.LogToFile(folderToLog + "\\" + nameOfFile, textures[imageIndex].name, startTime, endTime, framesToWait, patientInfo);
        Debug.Log(textures[imageIndex].name);
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

    // 0 - the .exe itself
    // 1 - folderpath of the images
    // 2 - displaying duration in frames
    // 3 - folder to log into
    // 4 - name of the logged file
    // 5 - patient info
    private void InitializeParams()
    {
        string[] parameters = Environment.GetCommandLineArgs();

        // Set fields
        this.folderPath = parameters[1];
        this.framesToWait = Int32.Parse(parameters[2]);
        this.folderToLog = parameters[3];
        this.nameOfFile = parameters[4];
        this.patientInfo = parameters[5];
    }
}
