using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class HUD : MonoBehaviour
{
    public Info I;
    public Image WButton;
    public Image AButton;
    public Image SButton;
    public Image DButton;
    public Image SprintButton;
    public Image InteractButton;
    public Image ExitButton;
    public Image JumpButton;
    public GameObject[] Audios;
    public GameObject[] Generals;
    public GameObject[] Keyboards;
    public GameObject[] Anothers;
    public Toggle FPSToggle;
    public Keyboardanager KM;
    public Text W;
    public Text A;
    public Text S;
    public Text D;
    public Text Interact;
    public Text Sprint;
    public Text Exit;
    public Text Jump;
    public Text Quality;
    public Slider MainThemeS;
    public Slider SoundS;
    public Slider Sensivity
    {
        get{return module.Find("SSlider").GetComponent<Slider>();}
    }
    public  Transform module{get{return transform.Find("Module");}}
    public void Start()
    {
        FPSToggle = GameObject.Find("HUD/Other/Toggle").GetComponent<Toggle>();
        Quality = GameObject.Find("HUD/General/Text123").GetComponent<Text>();
        MainThemeS = GameObject.Find("HUD/Slider (1)").GetComponent<Slider>();
        SoundS = GameObject.Find("HUD/Slider (2)").GetComponent<Slider>();
        WButton = GameObject.Find("HUD/Scroll/Content/Panel1/Button").GetComponent<Image>();
        SButton = GameObject.Find("HUD/Scroll/Content/Panel2/Button").GetComponent<Image>();
        AButton = GameObject.Find("HUD/Scroll/Content/Panel3/Button").GetComponent<Image>();
        DButton = GameObject.Find("HUD/Scroll/Content/Panel4/Button").GetComponent<Image>();
        SprintButton = GameObject.Find("HUD/Scroll/Content/Panel5/Button").GetComponent<Image>();
        InteractButton = GameObject.Find("HUD/Scroll/Content/Panel6/Button").GetComponent<Image>();
        ExitButton = GameObject.Find("HUD/Scroll/Content/Panel7/Button").GetComponent<Image>();
        JumpButton = GameObject.Find("HUD/Scroll/Content/Panel8/Button").GetComponent<Image>();
        GameObject.Find("HUD/Scroll/Scrollbar").GetComponent<Scrollbar>().value = 1;
        W = GameObject.Find("HUD/Scroll/Content/Panel1/Button/Text").GetComponent<Text>();
        S = GameObject.Find("HUD/Scroll/Content/Panel2/Button/Text").GetComponent<Text>();
        A = GameObject.Find("HUD/Scroll/Content/Panel3/Button/Text").GetComponent<Text>();
        D = GameObject.Find("HUD/Scroll/Content/Panel4/Button/Text").GetComponent<Text>();
        Interact = GameObject.Find("HUD/Scroll/Content/Panel6/Button/Text").GetComponent<Text>();
        Sprint = GameObject.Find("HUD/Scroll/Content/Panel5/Button/Text").GetComponent<Text>();
        Exit = GameObject.Find("HUD/Scroll/Content/Panel7/Button/Text").GetComponent<Text>();
        Jump = GameObject.Find("HUD/Scroll/Content/Panel8/Button/Text").GetComponent<Text>();
        MainThemeS.value = I.MainThemeVolume;
        SoundS.value = I.SoundsVolume;
        General();
    }
    public void Awake()
    {
            I = GameObject.Find("Info").GetComponent<Info>();
        Sensivity.value = 200;
        Audios = GameObject.FindGameObjectsWithTag("Audio");
        Generals = GameObject.FindGameObjectsWithTag("General");
        Keyboards = GameObject.FindGameObjectsWithTag("Keyboard");
        Anothers = GameObject.FindGameObjectsWithTag("Anothers");
        KM.enabled = false;
    }
    // Start is called before the first frame update
public void Update()
{
    I.FPSActive = FPSToggle.isOn;
    W.text = I.WalkForward.ToString();
        A.text = I.WalkLeft.ToString();
        S.text = I.WalkBackward.ToString();
        D.text = I.WalkRight.ToString();
        Interact.text = I.Interact.ToString();
        Sprint.text = I.Sprint.ToString();
        Exit.text = I.Exit.ToString();
        Jump.text = I.Jump.ToString();
    I.Sensivity = Sensivity.value;
    I.MainThemeVolume = MainThemeS.value;
    I.SoundsVolume = SoundS.value;
    KeyCode[]keys = {I.WalkForward, I.WalkLeft, I.WalkBackward, I.WalkRight, I.Jump, I.Exit, I.Interact, I.Sprint};
    Image[]KeyButtons = {WButton, AButton, SButton, DButton, JumpButton, ExitButton, InteractButton, SprintButton};
    for(int I = 0;I < keys.Length; I++)
    {
        for(int J = I + 1; J < keys.Length-1;J++)
        {
            if(keys[I] == keys[J])
            {
                KeyButtons[I].color = Color.red;
                //new Color(154, 11, 11, 1);
                KeyButtons[J].color = Color.red;
                Debug.Log(keys[I]);
                Debug.Log(keys[J]);
                I++;
                break;
            }
            else
            {
                KeyButtons[I].color = Color.white;
                KeyButtons[J].color = Color.white;
            }
        }
    }
    switch(QualitySettings.GetQualityLevel())
    { 
        case 0: Quality.text = "Potato";break;
        case 1: Quality.text = "Very Low";break;
        case 2: Quality.text = "Low";break;
        case 3: Quality.text = "Normal";break;
        case 4: Quality.text = "Hight";break;
        case 5: Quality.text = "Ultra";break;
    }
}
public void General()
    {
        UseAll(Generals,true);
        UseAll(Keyboards,false);
        UseAll(Audios, false);
        UseAll(Anothers, false);
    }
    public void Keyboard()
    {
        UseAll(Generals,false);
        UseAll(Keyboards,true);
        UseAll(Audios, false);
        UseAll(Anothers, false);
    }
    public void Audio()
    {
        UseAll(Generals,false);
        UseAll(Keyboards,false);
        UseAll(Audios, true);
        UseAll(Anothers, false);
    }
    public void Another()
    {
        UseAll(Generals,false);
        UseAll(Keyboards,false);
        UseAll(Audios, false);
        UseAll(Anothers, true);
    } 
    public void UseAll(GameObject[] list, bool state)
    {
        foreach(GameObject element in list)
        {
            element.SetActive(state);
        }
    }
    public void ChangeWalkBackward()
    {
        KM.enabled = true;
        KM.currentButton = "s";
    }
    public void ChangeWalkForward()
    {
        KM.enabled = true;
        KM.currentButton = "w";
    }
    public void ChangeWalkLeft()
    {   
        KM.enabled = true;
        KM.currentButton = "a";
    }
    public void ChangeWalkRight()
    {
        KM.enabled = true;
        KM.currentButton = "d";
    }
    public void ChangeSprint()
    {
        KM.enabled = true;
        KM.currentButton = "sprint";
    }
    public void ChangeInteract()
    {
        KM.enabled = true;
        KM.currentButton = "interact";
    }
    public void ChangeJump()
    {
        KM.enabled = true;
        KM.currentButton = "jump";
    }
    public void ChangeExit()
    {
        KM.enabled = true;
        KM.currentButton = "exit";
    }
    public void IfRed(string buttonName)
    {
        KeyCode[]keys = {I.WalkForward, I.WalkLeft, I.WalkBackward, I.WalkRight, I.Jump, I.Exit, I.Interact, I.Sprint};
        
    }
    public void QualityPlus()
    {
        QualitySettings.DecreaseLevel();
    }
    public void QualityMinus()
    {
        QualitySettings.IncreaseLevel();
    }
    public void ChangeFPSCount(int count)
    {
        Application.targetFrameRate = count;
    }
}
