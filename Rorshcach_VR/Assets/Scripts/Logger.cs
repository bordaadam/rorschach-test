using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

// TODO: 1db log metódus legyen, amibe bármit írhatok
public class Logger
{

    public static void LogToFile(string path, string nameOfImage, string startingTime, string endingTime, int framesToWait, string elapsedTime)
    {
        StreamWriter sw = new StreamWriter(path, true);
        string stringToWrite = nameOfImage + ";Vetítés kezdete: " + startingTime + ";Vetítés vége: " + endingTime + ";" + framesToWait  + " frame;" + "Eltelt idő: " + elapsedTime;
        sw.WriteLine(stringToWrite);
        sw.Close();
    }

    public static void Log(string path, string text)
    {
        StreamWriter sw = new StreamWriter(path, true);
        sw.WriteLine(text);
        sw.Close();
    }

}
