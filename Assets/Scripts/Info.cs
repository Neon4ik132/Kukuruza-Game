using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Info : MonoBehaviour
{
    public float MainThemeVolume = 0.5f;
    public AudioSource MainTheme;
    public float Sensivity = 200;
    public float SoundsVolume = 0.4f;
    public int Corn = 0;
    public int popcorn = 0;
    public int Token = 0;
    public int CornGathered = 0;
    public int CornPeeled = 0;
    public bool isTV = false;
    public bool isBowl = false;
    public bool isMixer = false;
    public bool isU1 = false;
    public bool isU2 = false;
    public bool isU3 = false;
    public bool isU4 = false;
    public bool FPSActive = false;
    public KeyCode WalkForward = KeyCode.W;
    public KeyCode WalkBackward = KeyCode.S;
    public KeyCode WalkLeft = KeyCode.A;
    public KeyCode WalkRight = KeyCode.D;
    public KeyCode Sprint = KeyCode.LeftShift;
    public KeyCode Interact = KeyCode.E;
    public KeyCode Exit = KeyCode.Q;
    public KeyCode Jump = KeyCode.Space;
    public KeyCode ExitButton = KeyCode.Q; 
    private bool isFirst = false;
    public bool MissingCorn = false;
    // Start is called before the first frame update
    void Start()
    {
        while(QualitySettings.GetQualityLevel() < 3)
        {
            QualitySettings.IncreaseLevel();
        }
        if(Time.time == 0)
        {
        //if (SceneManager.activeSceneChanged())`
        MainTheme.Play();
        DontDestroyOnLoad(this.gameObject);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        MainTheme.volume = MainThemeVolume;
    }
}
