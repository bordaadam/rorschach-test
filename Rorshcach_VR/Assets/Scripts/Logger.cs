using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Logger
{

    /// hova, kep neve, starting, ending ido, frame
    public static void LogToFile(string fileName, string nameOfImage, string startingTime, string endingTime, int framesToWait)
    {
        StreamWriter sw = new StreamWriter(fileName, true);
        string stringToWrite = nameOfImage + " kép lett megjelenítve. Vetítés kezdete: " + startingTime + ", vége: " + endingTime + " (" + framesToWait  + " frame)";
        sw.WriteLine(stringToWrite);
        Debug.Log(stringToWrite);
        sw.Close();
    }
}
