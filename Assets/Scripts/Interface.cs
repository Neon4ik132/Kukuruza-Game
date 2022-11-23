using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Interface : MonoBehaviour
{
public AudioSource Microwave;
public AudioSource Bowl;
public AudioSource FridgeOpen;
public AudioSource FridgeClose;
public Text tk;
public GameObject TKShop;
public Text Mess;
public ShopController SC;
public CameraRotate cam;
public Text Nigger;
public Text Nigger2;
public bool wait = false;
public Text NIGGGA;
public int TkC = 1000;
public Text Exit;
public Info I;
    // Start is called before the first frame update
    void Start()
    {
        SC = GameObject.Find("ShopButtonController1").GetComponent<ShopController>();
        I = GameObject.Find("Info").GetComponent<Info>();
        Exit = GameObject.Find("Interface/ExitText").GetComponent<Text>();
        TKShop = GameObject.Find("Interface/TokenMenu");
        Mess = GameObject.Find("Interface/Mess").GetComponent<Text>();
        Nigger = GameObject.Find("Interface/NIGGER").GetComponent<Text>();
        cam = this.gameObject.GetComponent<CameraRotate>();
        Nigger2 = GameObject.Find("Interface/Kak-to").GetComponent<Text>();
        TKShop.SetActive(false);
        if(I.MissingCorn)
        {
            I.popcorn++;
            I.MissingCorn = false;
        }
        //Shop.SetActive(false);
        if (I.isU4)
        {
            I.CornGathered = I.CornGathered * 5;
        }
        else if(I.isU3)
        {
            I.CornGathered = I.CornGathered * 3;
        }
        else if(I.isU2)
        {
            I.CornGathered = System.Convert.ToInt32(I.CornGathered * 1.5);
        }
        else if(I.isU1)
        {
            I.CornGathered = System.Convert.ToInt32(I.CornGathered * 1.5);
        }
        Debug.Log(I.CornGathered);
        I.Corn += I.CornGathered;
        I.CornGathered = 0;
    }

    // Update is called once per frame
    void Update()
    
    {
        Mess.text = "Нажмите "+I.Interact+" что бы открыть";
        Microwave.volume = I.SoundsVolume;
        Bowl.volume = I.SoundsVolume;
        Nigger.text = I.Corn.ToString();
        Nigger2.text = I.popcorn.ToString();
               RaycastHit hit;
if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))
{
    if (hit.transform.CompareTag("Pig_")&&Input.GetKeyDown(I.Interact))
    {
        hit.transform.gameObject.SetActive(false);
        int s1 = Random.Range(-10,10);
        Debug.Log(s1);
        if (s1 >= 0)
        {
            I.Corn += 10;
            //popcorn -=5;
        }
        else if (s1 < 0);
        {
            I.popcorn += 5;
        //corn -=10;
        }
    }
    if (hit.transform.CompareTag("Basket")&&!SC.Shop.activeInHierarchy)
    {
        Exit.enabled = true;
        if(Input.GetKeyDown(I.Interact))
        {
            SceneManager.LoadScene("Level");
        }
    }
    else
    {
        Exit.enabled = false;
    }
    if (hit.transform.CompareTag("Xoxlodilnik")||hit.transform.CompareTag("Microwave")||hit.transform.CompareTag("Bowl") )
    {
        Mess.enabled = true;
        if (hit.transform.CompareTag("Xoxlodilnik")&&Input.GetKeyDown(I.Interact)&&!SC.Shop.activeInHierarchy)
        {
            SC.Shop.SetActive(true);
            SC.ShopButtons.SetActive(true);
            Cursor.lockState = CursorLockMode.Confined;
            cam.enabled = false;
            FridgeOpen.Play();
        }
        else if (Input.GetKeyDown(I.Interact)&&(SC.Shop.activeInHierarchy||SC.Shop2.activeInHierarchy))
        {
            SC.Shop.SetActive(false);
            SC.Shop2.SetActive(false);
            SC.ShopButtons.SetActive(false);
            TKShop.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            cam.enabled = true;
            FridgeClose.Play();
        }
        if (hit.transform.CompareTag("Bowl")&&Input.GetKeyDown(I.Interact))
        {
            CornPeel();
        }
        if (hit.transform.CompareTag("Microwave")&&Input.GetKeyDown(I.Interact))
        {
            if (!wait)
            {
            StartCoroutine (CornRecycle());
            }
        }
    }
    else
    {
        Mess.enabled = false;
    }
} 
    }
    IEnumerator  CornRecycle()
    {
        I.MissingCorn = true;
        wait = true;
        Microwave.Play();
        if(I.isMixer)
        {
            if(I.CornPeeled >= 2)
            {
                I.CornPeeled -= 2;
                yield return new WaitForSeconds(5);
                I.popcorn += 2;
                
            }
            else if(I.CornPeeled > 0)
            {
                I.CornPeeled --;
                yield return new WaitForSeconds(5);
                I.popcorn ++;
            }
        }
        else
        {
        if (I.CornPeeled > 0)
        {
        I.CornPeeled--;
        yield return new WaitForSeconds(10);
        I.popcorn++;
        }
        Microwave.Stop();
    }
    wait = false;
    I.MissingCorn = false;
    }
    public void CornPeel()
    {
        Bowl.Play();
        if(I.isBowl)
        {
            if(I.Corn >= 5)
            {
                I.Corn -= 5;
                I.CornPeeled += 5;
            }
            else if(I.Corn > 0)
            {
                I.CornPeeled += I.Corn;
                I.Corn = 0;
            }
        }
        else
        {
            if (I.Corn > 0)
            {
                I.Corn--;
                I.CornPeeled++;
            }
        }
        //Bowl.Stop();
    }
}
