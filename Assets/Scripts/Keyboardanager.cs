using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Keyboardanager : MonoBehaviour
{
    public Info I;
    public string currentButton;
    // Start is called before the first frame update
    void Start()
    {
            I = GameObject.Find("Info").GetComponent<Info>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnGUI()
    {
        if(Input.anyKey&&Event.current.keyCode != KeyCode.None)
        {
            switch(currentButton)
            {
                case "w":
                {
                    
                    I.WalkForward = Event.current.keyCode;
                    break;
                }
                case "a":
                {
                    
                    I.WalkLeft = Event.current.keyCode;
                    break;
                }
                case "s":
                {
                    
                    I.WalkBackward = Event.current.keyCode;
                    break;
                }
                case "d":
                {
                    
                    I.WalkRight = Event.current.keyCode;
                    break;
                }
                case "interact":
                {
                    
                    I.Interact = Event.current.keyCode;
                    break;
                }
                case "sprint":
                {
                    
                    I.Sprint = Event.current.keyCode;
                    break;
                }
                case "exit":
                {
                    
                    I.Exit = Event.current.keyCode;
                    break;
                }
                case "jump":
                {
                    
                    I.Jump = Event.current.keyCode;
                    break;
                }
                default:break;
            }
            
            //this.enabled = false;
        }
    }
}
