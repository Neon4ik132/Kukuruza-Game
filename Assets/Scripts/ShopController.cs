using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShopController : MonoBehaviour
{
    public Info I;
    public GameObject B;
    public GameObject S;
    public GameObject TV;
    public GameObject TV_pic;
    public GameObject MW_Old;
    public GameObject Mixer;
    public Material M;
    public GameObject S3;
    public GameObject B3;
    public bool U1 = false;
    public bool U2 = false;
    public bool U3 = false;
    public bool U4 = false;
    public GameObject US1;
    public GameObject US2;
    public GameObject US3;
    public GameObject US4;
    public GameObject UB1;
    public GameObject UB2;
    public GameObject UB3;
    public GameObject UB4;
    public GameObject BB;
    public GameObject BS;
    public GameObject Shop;
    public GameObject Shop2;
    public GameObject MixerS;
    public GameObject MixerB;
    public Text tokenCounter;
    public Text popcornCounter;
    public GameObject ShopButtons;
    void Start()
    {
        ShopButtons = GameObject.Find("Interface/ShopButtons");
        popcornCounter = GameObject.Find("Interface/Shop/popcornCounter/NIGGGa").GetComponent<Text>();
        tokenCounter = GameObject.Find("Interface/Shop/tokenCounter/Text (2)").GetComponent<Text>();
        BB = GameObject.Find("Interface/Shop/Button");
        BS = GameObject.Find("Interface/Shop/Sold (1)");
        B = GameObject.Find("Interface/Shop/1 slot/Button");
        S = GameObject.Find("Interface/Shop/1 slot/Sold");
        Shop = GameObject.Find("Interface/Shop");
        Shop2 = GameObject.Find("Interface/Shop 2");
        MixerS = GameObject.Find("Interface/Shop/2 slot/Sold (2)");
        MixerB = GameObject.Find("Interface/Shop/2 slot/Button (Legacy)");
        US1 = GameObject.Find("Interface/Shop 2/1 slot/Sold (2)");
        US2 = GameObject.Find("Interface/Shop 2/2 slot/Sold (3)");
        US3 = GameObject.Find("Interface/Shop 2/3 slot/Sold (4)");
        US4 = GameObject.Find("Interface/Shop 2/4 slot/Sold (5)");
        UB1 = GameObject.Find("Interface/Shop 2/1 slot/Button (Legacy) (3)");
        UB2 = GameObject.Find("Interface/Shop 2/2 slot/Button (Legacy) (2)");
        UB3 = GameObject.Find("Interface/Shop 2/3 slot/Button (Legacy) (1)");
        UB4 = GameObject.Find("Interface/Shop 2/4 slot/Button (Legacy)");
        I = GameObject.Find("Info").GetComponent<Info>();
        MW_Old = GameObject.Find("Microwave_Oven");
        Mixer = GameObject.Find("Mixer");
        TV = GameObject.Find("TV");
        TV_pic = GameObject.Find("TV_70_pic");
        S3 = GameObject.Find("Interface/Shop/2 slot/Sold (2)");
        B3 = GameObject.Find("Interface/Shop/2 slot/Button (Legacy)");
        TV_pic.SetActive(false);
        Mixer.SetActive(false);
        S3.SetActive(false);
        US1.SetActive(false);
        US2.SetActive(false);
        US3.SetActive(false);
        US4.SetActive(false);
        Shop.SetActive(false);
        Shop2.SetActive(false);
        S.SetActive(false);
        BS.SetActive(false);
        ShopButtons.SetActive(false);
    }
public void Update()
{
    popcornCounter.text = I.popcorn.ToString();
    tokenCounter.text = I.Token.ToString();
}
    // Start is called before the first frame update
 public void ShopClick()
 {
     if (I.Token >= 50)
     {
         I.Token -= 50;
         B.SetActive(false);
         S.SetActive(true);
         TV.SetActive(false);
         TV_pic.SetActive(true);
         I.isTV = true;
     }
 }
 public void ShopClickBowl()
 {
     if (I.Token >= 80)
     {
         I.isBowl = true;
         I.Token -= 80;
         GameObject.Find("Bowl").GetComponent<MeshRenderer>().material = M;
         BB.SetActive(false);
         BS.SetActive(true);
     }
 }
 public void ShopClickMixer()
 {
    if (I.Token >= 100)
    {
        I.isMixer = true;
        I.Token -= 80;
        MW_Old.SetActive(false);
        Mixer.SetActive(true);
        MixerS.SetActive(true);
        MixerB.SetActive(false);
    }
 }
public void BuyU1()
{
    if(I.Token >= 40)
    {
        I.isU1 = true;
        U1 = true;
        US1.SetActive(true);
        UB1.SetActive(false);
        I.Token -= 40;
    }
    
}
public void BuyU2()
{
    if(I.Token >= 60)
    {
        I.isU2 = true;
        U2 = true;
        US2.SetActive(true);
        UB2.SetActive(false);
        I.Token -= 60;
    }
    
}
public void BuyU3()
{
    if(I.Token >= 120)
    {
        I.isU3 = true;
        U3 = true;
        US3.SetActive(true);
        UB3.SetActive(false);
        I.Token -= 120;
    }
    
}
public void BuyU4()
{
    if(I.Token >= 160)
    {
        I.isU4 = true;
        U4 = true;
        US4.SetActive(true);
        UB4.SetActive(false);
        I.Token -= 160;
    }
    
}
public void Forward()
{
    Shop.SetActive(false);
    Shop2.SetActive(true);
    Debug.Log(1);
}
public void Backword()
{
    Shop.SetActive(true);
    Shop2.SetActive(false);
    Debug.Log(2);
}
    // Update is called once per frame

}
