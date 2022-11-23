using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    float angle = 45f;
    public GameObject cow;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnCow());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public IEnumerator SpawnCow()
    {
        while(true)
        {
        float timer = Random.Range(10.0f,30.0f);
        yield return new WaitForSeconds(timer);
        GameObject NewCow = (GameObject)Instantiate(cow,this.transform.position,this.transform.rotation);
        Rigidbody r = NewCow.GetComponent<Rigidbody>();
        r.velocity = new Vector2(Mathf.Pow(3, .5f)/2, 1/2) * 100;
        Destroy(NewCow, 40f);
        }
    }
}
