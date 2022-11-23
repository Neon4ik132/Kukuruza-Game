using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CameraRotate : MonoBehaviour
{
    public Transform cam;
    private Vector3 camRotation;
    //public HUD hud;
    public int maxAngle = 45;
    public int minAngle = -30;
    public int min = -130;
    public int max = -60;
    public float sensivity = 200;
    private Info i;
    // Start is called before the first frame update
    
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        cam.transform.Rotate(25, -90, 0);
        i = GameObject.Find("Info").GetComponent<Info>();
    }

    // Update is called once per frame
    void Update()
    {
      Rotat();
      
    }
    private void Rotat()
    {
        transform.Rotate(Vector3.up * i.Sensivity * Time.deltaTime * Input.GetAxis("Mouse X"));

        camRotation.x -= Input.GetAxis("Mouse Y") * sensivity * Time.deltaTime;
        camRotation.x = Mathf.Clamp(camRotation.x, minAngle, maxAngle);
transform.Rotate(Vector3.right * sensivity * Time.deltaTime * Input.GetAxis("Mouse Y"));

        camRotation.y += Input.GetAxis("Mouse X") * sensivity * Time.deltaTime;
        camRotation.y = Mathf.Clamp(camRotation.y, min, max);
        cam.localEulerAngles = camRotation;
    }
}
