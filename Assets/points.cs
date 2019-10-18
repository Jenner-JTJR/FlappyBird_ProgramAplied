using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class points : MonoBehaviour
{
     public Game_Controller controller;
     void Start(){
       controller = FindObjectOfType<Game_Controller>();


     }
  void OnTriggerEnter2D(Collision2D colisor){
      controller.Score ++;
      controller.ScoreText.text = controller.Score.ToString();
  }

}
