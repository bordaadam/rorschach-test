using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DataHolder : MonoBehaviour
{
    public static DataHolder Instance { get; set; }
    public string ImagesFolder { get; set; }
    public int Frames { get; set; }
    public string FolderToLog { get; set; }
    public string LogFileName { get; set; }
    public TimeSpan StartingDateTime { get; set; }

    [SerializeField] private bool debug = false;

    private void Awake() 
    {
        if(Instance == null) Instance = this;
    }

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
