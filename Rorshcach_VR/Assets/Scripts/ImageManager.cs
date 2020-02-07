using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

//TODO: szépíteni a kódot
//TODO: lehet itt kéne az audioclip és amazt az osztály teljesen kitörölhetnénk, és itt érnénk el simán a sawwav-t
//TODO: csak akkor írjuk át mondjuk ezt Master-re.
public class ImageManager : MonoBehaviour
{
    private List<Texture2D> textures;
    [SerializeField] private RawImage rawImageComponent;
    private string cmdInfo = "";
    private int secondsFromStart = 0;
    private TimeSpan startingDateTime;
    DataHolder data;

    void Start()
    {
        data = DataHolder.Instance;
        data.InitializeParams();
        textures = Reader.GetImagesFromDirectory(data.ImagesFolder);
        Debug.Log("Betöltött képek száma: " + textures.Count);
        cmdInfo += data.ImagesFolder + "\n" + data.Frames + "\n" + data.FolderToLog + "\n" + data.LogFileName + "\n" + data.StartingDateTime;
        startingDateTime = data.StartingDateTime;
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
            StartCoroutine(WaitForXFrames(data.Frames, 0));
        }
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            StartCoroutine(WaitForXFrames(data.Frames, 1));
        }
        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            StartCoroutine(WaitForXFrames(data.Frames, 2));
        }
        if(Input.GetKeyDown(KeyCode.Alpha3))
        {
            StartCoroutine(WaitForXFrames(data.Frames, 3));
        }
        if(Input.GetKeyDown(KeyCode.Alpha4))
        {
            StartCoroutine(WaitForXFrames(data.Frames, 4));
        }
        if(Input.GetKeyDown(KeyCode.Alpha5))
        {
            StartCoroutine(WaitForXFrames(data.Frames, 5));
        }
        if(Input.GetKeyDown(KeyCode.Alpha6))
        {
            StartCoroutine(WaitForXFrames(data.Frames, 6));
        }
        if(Input.GetKeyDown(KeyCode.Alpha7))
        {
            StartCoroutine(WaitForXFrames(data.Frames, 7));
        }
        if(Input.GetKeyDown(KeyCode.Alpha8))
        {
            StartCoroutine(WaitForXFrames(data.Frames, 8));
        }
        if(Input.GetKeyDown(KeyCode.Alpha9))
        {
            StartCoroutine(WaitForXFrames(data.Frames, 9));
        }

        if(Input.GetKeyDown(KeyCode.Keypad0))
        {
            StartCoroutine(WaitForXFrames(data.Frames, 10));
        }
        if(Input.GetKeyDown(KeyCode.Keypad1))
        {
            StartCoroutine(WaitForXFrames(data.Frames, 11));
        }
        if(Input.GetKeyDown(KeyCode.Keypad2))
        {
            StartCoroutine(WaitForXFrames(data.Frames, 12));
        }
        if(Input.GetKeyDown(KeyCode.Keypad3))
        {
            StartCoroutine(WaitForXFrames(data.Frames, 13));
        }
        if(Input.GetKeyDown(KeyCode.Keypad4))
        {
            StartCoroutine(WaitForXFrames(data.Frames, 14));
        }
        if(Input.GetKeyDown(KeyCode.Keypad5))
        {
            StartCoroutine(WaitForXFrames(data.Frames, 15));
        }
        if(Input.GetKeyDown(KeyCode.Keypad6))
        {
            StartCoroutine(WaitForXFrames(data.Frames, 16));
        }
        if(Input.GetKeyDown(KeyCode.Keypad7))
        {
            StartCoroutine(WaitForXFrames(data.Frames, 17));
        }
        if(Input.GetKeyDown(KeyCode.Keypad8))
        {
            StartCoroutine(WaitForXFrames(data.Frames, 18));
        }
        if(Input.GetKeyDown(KeyCode.Keypad9))
        {
            StartCoroutine(WaitForXFrames(data.Frames, 19));
        }

        if(Input.GetKeyDown(KeyCode.R))
        {
            StartCoroutine(WaitForXFrames(data.Frames, 20));
        }
        if(Input.GetKeyDown(KeyCode.F))
        {
            StartCoroutine(WaitForXFrames(data.Frames, 21));
        }
        if(Input.GetKeyDown(KeyCode.T))
        {
            StartCoroutine(WaitForXFrames(data.Frames, 22));
        }
        if(Input.GetKeyDown(KeyCode.G))
        {
            StartCoroutine(WaitForXFrames(data.Frames, 23));
        }
        if(Input.GetKeyDown(KeyCode.Z))
        {
            StartCoroutine(WaitForXFrames(data.Frames, 24));
        }
        if(Input.GetKeyDown(KeyCode.H))
        {
            StartCoroutine(WaitForXFrames(data.Frames, 25));
        }
        if(Input.GetKeyDown(KeyCode.U))
        {
            StartCoroutine(WaitForXFrames(data.Frames, 26));
        }
        if(Input.GetKeyDown(KeyCode.J))
        {
            StartCoroutine(WaitForXFrames(data.Frames, 27));
        }
        if(Input.GetKeyDown(KeyCode.I))
        {
            StartCoroutine(WaitForXFrames(data.Frames, 28));
        }
        if(Input.GetKeyDown(KeyCode.K))
        {
            StartCoroutine(WaitForXFrames(data.Frames, 29));
        }


    }

    private IEnumerator WaitForXFrames(int x, int index)
    {
        if(index >= textures.Count)
            yield break;

        rawImageComponent.texture = textures[index];
        ShowImage(true);

        DateTime current = DateTime.Now;
        string startTime = current.ToString("HH:mm:ss.fff");
        while(x > 0)
        {
            x--;
            yield return null;
        }
        ShowImage(false);
        string endTime = DateTime.Now.ToString("HH:mm:ss.fff");
        TimeSpan elapsedTime = TimeSpan.Parse(startTime) - startingDateTime;
        Logger.LogToFile(data.FolderToLog + "\\" + data.LogFileName, textures[index].name, startTime, endTime, data.Frames, elapsedTime.TotalSeconds.ToString());
        Debug.Log("Ez a kep lett megjelenitve: " + textures[index].name);
    }

    private void ShowImage(bool show)
    {
        rawImageComponent.enabled = show;
    }

}
