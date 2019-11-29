using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ImageManager : MonoBehaviour
{
    private List<Texture2D> textures;
    [SerializeField] private RawImage rawImageComponent;
    
    [SerializeField] private int framesToWait = 10;
    
    private string folderPath;
    private string folderToLog;
    private string nameOfFile;
    private string patientInfo;

    private string cmdInfo = "";

    private int secondsFromStart = 0;

    private DateTime startingDateTime;

    void Awake()
    {
        //-------DEBUG-------
        InitializeParams();
        //this.folderPath = "D:\\kepek";
        //-------DEBUG-------


        textures = Reader.GetImagesFromDirectory(folderPath);
        Debug.Log("Ennyi kep lett betoltve: " + textures.Count);
        
    }

    void Start()
    {
        if(rawImageComponent == null)
        {
            Debug.LogWarning("RawImageComponent is null, but it shouldn't be!");

        }

        if(!Logger.FileExists(folderToLog + "\\" + nameOfFile))
        {
            Logger.LogPatientDescription(folderToLog + "\\" + nameOfFile, patientInfo);
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

        startingDateTime = DateTime.Now;
    }

    void OnGUI()
     {
         Rect r = new Rect(5,5, 800, 500);
         GUI.Label(r, cmdInfo);
     }

    void Update()
    {
        HandleInput();
    }

    // TODO: Optimize input
    private void HandleInput()
    {
        if(Input.GetKeyDown(KeyCode.Alpha0))
        {
            StartCoroutine(WaitForXFrames(framesToWait, 0));
        }
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            StartCoroutine(WaitForXFrames(framesToWait, 1));
        }
        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            StartCoroutine(WaitForXFrames(framesToWait, 2));
        }
        if(Input.GetKeyDown(KeyCode.Alpha3))
        {
            StartCoroutine(WaitForXFrames(framesToWait, 3));
        }
        if(Input.GetKeyDown(KeyCode.Alpha4))
        {
            StartCoroutine(WaitForXFrames(framesToWait, 4));
        }
        if(Input.GetKeyDown(KeyCode.Alpha5))
        {
            StartCoroutine(WaitForXFrames(framesToWait, 5));
        }
        if(Input.GetKeyDown(KeyCode.Alpha6))
        {
            StartCoroutine(WaitForXFrames(framesToWait, 6));
        }
        if(Input.GetKeyDown(KeyCode.Alpha7))
        {
            StartCoroutine(WaitForXFrames(framesToWait, 7));
        }
        if(Input.GetKeyDown(KeyCode.Alpha8))
        {
            StartCoroutine(WaitForXFrames(framesToWait, 8));
        }
        if(Input.GetKeyDown(KeyCode.Alpha9))
        {
            StartCoroutine(WaitForXFrames(framesToWait, 9));
        }

        if(Input.GetKeyDown(KeyCode.Keypad0))
        {
            StartCoroutine(WaitForXFrames(framesToWait, 10));
        }
        if(Input.GetKeyDown(KeyCode.Keypad1))
        {
            StartCoroutine(WaitForXFrames(framesToWait, 11));
        }
        if(Input.GetKeyDown(KeyCode.Keypad2))
        {
            StartCoroutine(WaitForXFrames(framesToWait, 12));
        }
        if(Input.GetKeyDown(KeyCode.Keypad3))
        {
            StartCoroutine(WaitForXFrames(framesToWait, 13));
        }
        if(Input.GetKeyDown(KeyCode.Keypad4))
        {
            StartCoroutine(WaitForXFrames(framesToWait, 14));
        }
        if(Input.GetKeyDown(KeyCode.Keypad5))
        {
            StartCoroutine(WaitForXFrames(framesToWait, 15));
        }
        if(Input.GetKeyDown(KeyCode.Keypad6))
        {
            StartCoroutine(WaitForXFrames(framesToWait, 16));
        }
        if(Input.GetKeyDown(KeyCode.Keypad7))
        {
            StartCoroutine(WaitForXFrames(framesToWait, 17));
        }
        if(Input.GetKeyDown(KeyCode.Keypad8))
        {
            StartCoroutine(WaitForXFrames(framesToWait, 18));
        }
        if(Input.GetKeyDown(KeyCode.Keypad9))
        {
            StartCoroutine(WaitForXFrames(framesToWait, 19));
        }

        if(Input.GetKeyDown(KeyCode.R))
        {
            StartCoroutine(WaitForXFrames(framesToWait, 20));
        }
        if(Input.GetKeyDown(KeyCode.F))
        {
            StartCoroutine(WaitForXFrames(framesToWait, 21));
        }
        if(Input.GetKeyDown(KeyCode.T))
        {
            StartCoroutine(WaitForXFrames(framesToWait, 22));
        }
        if(Input.GetKeyDown(KeyCode.G))
        {
            StartCoroutine(WaitForXFrames(framesToWait, 23));
        }
        if(Input.GetKeyDown(KeyCode.Z))
        {
            StartCoroutine(WaitForXFrames(framesToWait, 24));
        }
        if(Input.GetKeyDown(KeyCode.H))
        {
            StartCoroutine(WaitForXFrames(framesToWait, 25));
        }
        if(Input.GetKeyDown(KeyCode.U))
        {
            StartCoroutine(WaitForXFrames(framesToWait, 26));
        }
        if(Input.GetKeyDown(KeyCode.J))
        {
            StartCoroutine(WaitForXFrames(framesToWait, 27));
        }
        if(Input.GetKeyDown(KeyCode.I))
        {
            StartCoroutine(WaitForXFrames(framesToWait, 28));
        }
        if(Input.GetKeyDown(KeyCode.K))
        {
            StartCoroutine(WaitForXFrames(framesToWait, 29));
        }


    }

    private IEnumerator WaitForXFrames(int x, int index)
    {
        if(index >= textures.Count)
            yield break;

        rawImageComponent.texture = textures[index];
        ShowImage();

        //innen kell a különbséget száolnunk

        DateTime current = DateTime.Now;
        string startTime = current.ToString("HH:mm:ss.fff");
        while(x > 0)
        {
            x--;
            yield return null;
        }
        HideImage();
        string endTime = DateTime.Now.ToString("HH:mm:ss.fff");
        TimeSpan elapsedTime = current - startingDateTime;
        //------DEBUG
        Logger.LogToFile(folderToLog + "\\" + nameOfFile, textures[index].name, startTime, endTime, framesToWait, elapsedTime.ToString());
        //------DEBUG
        //Debug.Log("Ez a kep lett megjelenitve: " + textures[index].name);
    }

    private void ShowImage()
    {
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
