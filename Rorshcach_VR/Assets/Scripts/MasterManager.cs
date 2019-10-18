using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MasterManager : MonoBehaviour
{
    [SerializeField] private Texture[] textures; // This contains all of the pictures
    [SerializeField] private RawImage rawImageComponent;
    [SerializeField] private int framesToWait;
    private int imageIndex = 0;

    void Awake()
    {
        // TODO: read into textures all of the pictures (textures)
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(WaitForXFrames(10));
        }

    }

    private void ShowImage()
    {
        if(imageIndex > textures.Length - 1)
            imageIndex = 0; // Avoid IndexOutOfBoundsException

        rawImageComponent.texture = textures[imageIndex];
        imageIndex++;
        rawImageComponent.enabled = true;
    }

    private void HideImage()
    {
        rawImageComponent.enabled = false;
    }

    private IEnumerator WaitForXFrames(int x)
    {
        ShowImage();
        while(x > 0)
        {
            x--;
            yield return null;
        }
        HideImage();
    }
}
