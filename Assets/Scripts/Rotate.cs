using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Rotate : MonoBehaviour
{
    public Transform cam;
    private Vector3 camRotation;
    //public HUD hud;
    public int maxAngle = 45;
    public int minAngle = -30;
    public float sensivity = 200;
    // Start is called before the first frame update
    
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        //hud = GameObject.Find("HUD").GetComponent("HUD") as HUD;
    }

    // Update is called once per frame
    void Update()
    {
      Rotat();
      if(GameObject.Find("HUD").GetComponent<HUD>())
      {
      sensivity = GameObject.Find("HUD").GetComponent<HUD>().Sensivity.value;
      }
    }
    private void Rotat()
    {
        transform.Rotate(Vector3.up * sensivity * Time.deltaTime * Input.GetAxis("Mouse X"));

        camRotation.x -= Input.GetAxis("Mouse Y") * sensivity * Time.deltaTime;
        camRotation.x = Mathf.Clamp(camRotation.x, minAngle, maxAngle);

        cam.localEulerAngles = camRotation;
    }
}
