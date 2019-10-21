using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Reader
{
    private const int _WIDTH = 640;
    private const int _HEIGHT = 480;

    public static List<Texture2D> GetImagesFromDirectory(string path)
    {

        if(Directory.Exists(path))
        {
            List<Texture2D> tmp = new List<Texture2D>();

            string[] images = Directory.GetFiles(path);
            foreach(var name in images)
            {
                Debug.Log(name);
                tmp.Add(LoadImage(name));
            }

            return tmp;
        }

        return null;

    }


    // Should only be pictures. If its not a picture, it shows a big red question mark - no error given
    private static Texture2D LoadImage(string name)
    {
        Texture2D tex = null;
        byte[] fileData;
        fileData = File.ReadAllBytes(name);
        tex = new Texture2D(_WIDTH, _HEIGHT);
        tex.name = name; // TODO: chop name of the file (D:\pictures\r1.png --> r1.png)
        tex.LoadImage(fileData);

        return tex;
    } 
}
