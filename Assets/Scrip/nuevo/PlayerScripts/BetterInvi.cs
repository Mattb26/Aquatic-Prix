using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BetterInvi : MonoBehaviour
{
    private Color myColor;       //r g b and a      r=red , b=blue , g=green , a=alpha ,  //They go 0 to 1. by default they go 0

    public MeshRenderer myRenderer;


void Update()
{
gameObject.GetComponent<MeshRenderer>().material.color = Color.blue;



}

public void cambioDeLayerHaciaInvisible()
 {
      if (this.gameObject.tag == "Player1")  
      {
          gameObject.layer = 6;
      }
      if (this.gameObject.tag == "Player2")  
      {
          gameObject.layer = 7;
      }
      if (this.gameObject.tag == "Player3")  
      {
          gameObject.layer = 8;
      }
      if (this.gameObject.tag == "Player4")  
      {
          gameObject.layer = 9;
      }

 }


}

