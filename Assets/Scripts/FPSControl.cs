using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FPSControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.GetComponent<Text>().enabled = GameObject.Find("Info").GetComponent<Info>().FPSActive;
        this.gameObject.GetComponent<Text>().text = (1/Time.deltaTime).ToString();
    }
}
