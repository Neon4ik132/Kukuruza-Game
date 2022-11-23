using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public Info I;
    void Start()
    {
        I = GameObject.Find("Info").GetComponent<Info>();
    }

    void Update()
    {
        SwichInventory();
    }
    void SwichInventory()
    {
        if (Input.GetKeyDown(I.Interact))
        {
            if (this.gameObject.GetComponent<Canvas>().enabled)
            {
                this.gameObject.GetComponent<Canvas>().enabled = false;
            }
            else if(!this.gameObject.GetComponent<Canvas>().enabled)
            {
                this.gameObject.GetComponent<Canvas>().enabled = true;
            }
        }
    }
}
