using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Reader {
    private const int _WIDTH = 640;
    private const int _HEIGHT = 480;

    public static List<Texture2D> GetImagesFromDirectory(string path) {

        if(Directory.Exists(path)) {
            List<Texture2D> tmp = new List<Texture2D>();

            string[] images = Directory.GetFiles(path);
            foreach(var name in images) {
                tmp.Add(LoadImage(name));
            }

            return tmp;
        }

        return null;

    }


    private static Texture2D LoadImage(string name) {
        Texture2D text = null;
        byte[] fileData;
        fileData = File.ReadAllBytes(name);
        text = new Texture2D(_WIDTH, _HEIGHT);
        text.name = name;
        text.LoadImage(fileData);

        return text;
    } 
}
