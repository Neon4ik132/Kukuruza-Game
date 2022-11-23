using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Gm2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public int SceneN;
    public Canvas C;
    // Start is called before the first frame update
    public void B()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Cancel"))
    {
        if (!C.enabled)
        {
            C.enabled = true;
            Cursor.lockState = CursorLockMode.Confined;
        }
        else
    {
        C.enabled = false;
    }  
    }
    }
}
