using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonPlay : MonoBehaviour
{
    // Start is called before the first frame update
 public void play()
 {
     SceneManager.LoadScene("Level");
 }
}
