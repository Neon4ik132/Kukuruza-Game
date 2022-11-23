using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PigSpawner : MonoBehaviour
{
    public GameObject pig;
    void Start()
    {
        StartCoroutine(SpawnPig());
    }

    public IEnumerator SpawnPig()
    {
    while(true)
        {
        float timer = Random.Range(30.0f,50.0f);
        yield return new WaitForSeconds(timer);
        GameObject NewPig = (GameObject)Instantiate(pig,this.transform.position,this.transform.rotation);
        }
    }
}
