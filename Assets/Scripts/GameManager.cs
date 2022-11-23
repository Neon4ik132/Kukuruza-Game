using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public GameObject player;
    public Transform spawn;
    // Start is called before the first frame update
    void Start()
    {
        SpawnPlayer();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void SpawnPlayer()
    {
        Instantiate(player, spawn.position, Quaternion.identity);
    }
}
