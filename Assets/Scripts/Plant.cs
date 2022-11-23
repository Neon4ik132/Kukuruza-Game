using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plant : MonoBehaviour
{
    public GameObject corn;
    public GameObject tomato;
    public GameObject eggplaant;
    public GameObject cabbage;
    public int rand;
    // Start is called before the first frame update
    void Start()
    {
        rand = Random.Range(1, 5);
        switch (rand)
        {
            case 1:
            {
                Instantiate(corn, new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), Quaternion.identity);
                break;
            }
            case 2:
            {
                Instantiate(tomato, new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), Quaternion.identity);
                break;
            }
            case 3:
            {
                Instantiate(eggplaant, new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), Quaternion.identity);
                break;
            }
            case 4:
            {
                Instantiate(cabbage, new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), Quaternion.identity);
                break;
            }
            case 5:
            {
                break;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
