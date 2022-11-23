using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class CameraM : MonoBehaviour
{
    public Text cornCounter;
    public Text tomatoCounter;
    public Text cabadgeCounter;
    public Text eggplantCounter;
    public Info I;
    public int cabadgeScore = 0;
    public int eggplantScore = 0;
    public int tomatoScore = 0;
    public Text NNigga;
    void Start()
    {
        I = GameObject.Find("Info").GetComponent<Info>();
        cornCounter = GameObject.Find("HUD/Slot 5/Slot 5 count").GetComponent<Text>();
        cabadgeCounter = GameObject.Find("HUD/Slot 4/Slot 4 count").GetComponent<Text>();
        tomatoCounter = GameObject.Find("HUD/Slot 3/Slot 3 count").GetComponent<Text>();
        eggplantCounter = GameObject.Find("HUD/Slot 2/Slot 2 count").GetComponent<Text>();
        NNigga = GameObject.Find("GUI/Negro").GetComponent<Text>();
        NNigga.enabled = false;
    }
    void Update()
    {
        NNigga.text = "Нажмите "+I.Exit+" для перехода на след. сцену";
        cornCounter.text = I.CornGathered.ToString();
        tomatoCounter.text = tomatoScore.ToString();
        eggplantCounter.text = eggplantScore.ToString();
        cabadgeCounter.text = cabadgeScore.ToString();
        if (I.CornGathered >= 10)
        {
        NNigga.enabled = true;
        if (Input.GetKeyDown(I.Exit))
    {
        
        SceneManager.LoadScene("1");
    }
        }
        RaycastHit hit;
if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))
    {
        if ((hit.transform.CompareTag("Kukuruza")||hit.transform.CompareTag("Pomidor")||hit.transform.CompareTag("Eggplant")||hit.transform.CompareTag("Kapusta")) && Input.GetMouseButtonDown(0))
        {

            
            if (hit.transform.CompareTag("Kukuruza"))
            {
                I.CornGathered += 1;
            }
            else if (hit.transform.CompareTag("Pomidor"))
            {
                tomatoScore += 1;
            }
            else if (hit.transform.CompareTag("Eggplant"))
            {
                eggplantScore += 1;
            }
            else if (hit.transform.CompareTag("Kapusta"))
            {
                cabadgeScore += 1;
            }
            Destroy(hit.collider.gameObject);
            }
        }
    }
    //}
    
}