using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Pipes : MonoBehaviour
{
    public GameObject pipe;
    public float height;
    public float MaxTime;
    private float Timer = 0F;

    // Start is called before the first frame update
    void Start()
    {
        GameObject newPipes = Instantiate(pipe);
        newPipes.transform.position = transform.position + new Vector3(0,Random.Range(-height,height),0);
    }

    // Update is called once per frame
    void Update()
    {
        if(Timer > MaxTime){
            GameObject newPipes = Instantiate(pipe);
                 newPipes.transform.position = transform.position + new Vector3(0,Random.Range(-height,height),0);
                    Destroy(newPipes, 5f);
                    Timer = 0;
                

        }
    Timer += Time.deltaTime;
    }
}
