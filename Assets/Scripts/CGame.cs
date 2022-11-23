using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System;
using UnityEngine.SceneManagement;
public class CGame : MonoBehaviour
{
    int ScornCounter;
    int SpopcornCounter;
    int StokenCounter;
    string SSceneName;
    bool STV;
    int RAWCornCounter;
    public void C()
    {
        if (File.Exists(Application.persistentDataPath + "/MySaveData.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/MySaveData.dat", FileMode.Open);
            SaveData data = (SaveData)bf.Deserialize(file);
            file.Close();
            ScornCounter = data.SDcornCounter;
            StokenCounter = data.SDtokenCounter;
            SpopcornCounter = data.SDpopcornCounter;
            SSceneName = data.SDSceneName;
            STV = data.SDTV;
            RAWCornCounter = data.SDRAWCornCounter;
            Debug.Log("Game data loaded!");
            SceneManager.LoadScene(SSceneName);
            Debug.Log(SSceneName);
        }
        else
        {
            Debug.LogError("There is no save data!");
        }
    }
}