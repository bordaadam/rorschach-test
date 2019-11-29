using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Logger
{

    public static void LogToFile(string path, string nameOfImage, string startingTime, string endingTime, int framesToWait, string currentTime)
    {
        StreamWriter sw = new StreamWriter(path, true);
        string stringToWrite = nameOfImage + " kép;Vetítés kezdete: " + startingTime + ";Vetítés vége: " + endingTime + ";" + framesToWait  + " frame;" + "Eltelt idő: " + currentTime;
        sw.WriteLine(stringToWrite);
        sw.Close();
    }

    public static void LogPatientDescription(string path, string patientInfo)
    {
        StreamWriter sw = new StreamWriter(path, true);
        sw.WriteLine(patientInfo);
        sw.Close();
    }

    public static bool FileExists(string path)
    {
        return File.Exists(path);
    }

}
