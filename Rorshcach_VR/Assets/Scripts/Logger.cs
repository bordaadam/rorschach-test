using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Logger
{

    public static void LogToFile(string path, string nameOfImage, string startingTime, string endingTime, int framesToWait, string patientInfo)
    {
        StreamWriter sw = new StreamWriter(path, true);
        string stringToWrite = "Páciens: " + patientInfo + ";" +  nameOfImage + " kép;Vetítés kezdete: " + startingTime + ";Vetítés vége: " + endingTime + ";" + framesToWait  + " frame";
        sw.WriteLine(stringToWrite);
        sw.Close();
    }

}
