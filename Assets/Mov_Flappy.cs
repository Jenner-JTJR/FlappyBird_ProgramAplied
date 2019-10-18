using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov_Flappy : MonoBehaviour
{
    public GameObject GameOver;
    public float speed = 1f;
    private Rigidbody2D Rig;
    // Start is called before the first frame update
    void Start()
    {
        Rig = GetComponent<Rigidbody2D>();

        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){

                Rig.velocity = Vector2.up*speed;

        }
    }
    void OnCollisionEnter2D(Collision2D colisor){
        Time.timeScale = 0;
        GameOver.SetActive(true);
       
        

    }
 
}
