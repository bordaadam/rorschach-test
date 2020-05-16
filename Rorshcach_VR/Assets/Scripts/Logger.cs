using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Logger
{

    public static void LogToFile(string path, string nameOfImage, string startingTime, string endingTime, int framesToWait, string elapsedTime)
    {
        using(StreamWriter sw = new StreamWriter(path, true)) 
        {
            string stringToWrite = nameOfImage + ";Vetítés kezdete: " + startingTime + ";Vetítés vége: " + endingTime + ";" + framesToWait  + " frame;" + "Eltelt idő: " + elapsedTime;
            sw.WriteLine(stringToWrite);
        }
    }

}
