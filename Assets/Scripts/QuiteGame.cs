using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System;
public class QuiteGame : MonoBehaviour
{
    int ScornCounter;
    int SpopcornCounter;
    int StokenCounter;
    string SSceneName;
    bool STV;
    int RAWCornCounter;
    public int SceneN;
    // Start is called before the first frame update
    public void Q()
    {
        if (SceneN == 1)
        {
            RAWCornCounter = GameObject.Find("1(Clone)/Camera").GetComponent<CameraM>().I.Corn;
            SSceneName = "Level";
        }
        if (SceneN == 2)
        {
            SpopcornCounter = GameObject.Find("Info").GetComponent<Info>().Corn;
            StokenCounter = GameObject.Find("Info").GetComponent<Info>().Token;
            STV = GameObject.Find("Info").GetComponent<Info>().isTV;
            SSceneName = "1";
        }
        BinaryFormatter BF = new BinaryFormatter();
        FileStream F = File.Open(Application.persistentDataPath + "/MySaveData.dat",FileMode.Open);
        SaveData Data = new SaveData();
        Data.SDcornCounter = ScornCounter;
        Data.SDpopcornCounter = SpopcornCounter;
        Data.SDtokenCounter = StokenCounter;
        Data.SDSceneName = SSceneName;
        Data.SDTV = STV;
        Data.SDRAWCornCounter = RAWCornCounter;
        BF.Serialize(F,Data);
        //SaveData Data = (SaveData)BF.Deserialize(F);
        F.Close();
        Debug.Log("Saved");
        Application.Quit();
    }
}
[Serializable]
class SaveData
{
    public int SDcornCounter;
    public int SDpopcornCounter;
    public int SDtokenCounter;
    public string SDSceneName;
    public bool SDTV;
    public int SDRAWCornCounter;
}