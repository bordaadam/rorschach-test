using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public static class AudioManager
{

    public static AudioClip audioClip;

    //TODO: a foldertolog-hoz mentse el mindig!
    //TODO: lehet nem is kéne ez az osztályt, és a fieldet meg az imagemanager-nek átadni.
    public static void SaveAudioClipToWav(string name)
    {
        SavWav.Save(name, audioClip);
    }
}
