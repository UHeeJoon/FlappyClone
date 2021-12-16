using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePipe : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pipe;
    float timer = 0;
    public float timeDiff;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer +=Time.deltaTime;
        if(timer > timeDiff){
            GameObject newpipe = Instantiate(pipe);
            newpipe.transform.position = new Vector3(3.6f, Random.Range(-5f, 1.4f), 0);
            timer = 0;
            Destroy(newpipe,10.0f);
        }

    }
}
