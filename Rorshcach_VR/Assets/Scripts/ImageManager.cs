using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ImageManager : MonoBehaviour
{
    [SerializeField] private RawImage rawImageComponent;
    private int secondsFromStart = 0;
    DataHolder data;
    private List<Texture2D> textures;

    void Start()
    {
        data = DataHolder.Instance;
        data.InitializeParams();
        textures = Reader.GetImagesFromDirectory(data.ImagesFolder);
    }


    void Update()
    {
        if(Input.anyKeyDown) {
            foreach(var key in KeyBinding.binding.Keys) {
                if(Input.GetKeyDown(key)) {
                    StartCoroutine(WaitForXFrames(KeyBinding.binding[key]));
                }
            }
        }
    }

    private IEnumerator WaitForXFrames(int index)
    {
        if(index >= textures.Count)
            yield break;

        int x = data.Frames;

        rawImageComponent.texture = textures[index];
        ShowImage(true);

        string startTime = DateTime.Now.ToString("HH:mm:ss.fff");
        while(x >= 0)
        {
            x--;
            yield return null;
        }
        ShowImage(false);
        string endTime = DateTime.Now.ToString("HH:mm:ss.fff");
        TimeSpan elapsedTime = TimeSpan.Parse(startTime) - data.StartingDateTime;

        Logger.LogToFile(data.FolderToLog + "\\" + data.LogFileName, textures[index].name, startTime, endTime, data.Frames, elapsedTime.TotalSeconds.ToString());

    }

    private void ShowImage(bool show)
    {
        rawImageComponent.enabled = show;
    }

}
