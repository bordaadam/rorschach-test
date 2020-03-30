using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

//TODO: legyen az eglész static? nem is kéne instance singletonnak lennie!
public class DataHolder : MonoBehaviour
{
    public static DataHolder Instance { get; set; }

    [SerializeField] private bool debug = false;
    public string ImagesFolder { get; set; }
    public int Frames { get; set; }
    public string FolderToLog { get; set; }
    public string LogFileName { get; set; }
    public TimeSpan StartingDateTime { get; set; }

    private void Awake() 
    {
        if(Instance == null) Instance = this;

    }

    // 0 - the .exe itself
    // 1 - folderpath of the images
    // 2 - displaying duration in frames
    // 3 - folder to log into
    // 4 - name of the logged file
    // 5 - time
    public void InitializeParams()
    {
        if(!debug)
        {
            string[] parameters = Environment.GetCommandLineArgs();
            ImagesFolder = parameters[1];
            Frames = Int32.Parse(parameters[2]);
            FolderToLog = parameters[3];
            LogFileName = parameters[4];
            StartingDateTime = TimeSpan.Parse(parameters[5]);
        } 
        else 
        {
            ImagesFolder = "D:\\Szakdolgozat_Cuccok\\kepek";
            Frames = 10;
            FolderToLog = "D:\\Szakdolgozat_Cuccok";
            LogFileName = "DefaultFile.txt";
            StartingDateTime = TimeSpan.Parse("21:51:51.123");
        }
    }
}
