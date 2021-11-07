using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ifnoparents : MonoBehaviour
{
  [HideInInspector] 
   public float Timer = 0;
    [HideInInspector]
    
 
public void Start() 
{

 
}
  void FixedUpdate() 
    {
if(this.gameObject.transform.parent == null)

    {
    
   
    gameObject.GetComponent<ThirdPersonCamera>().enabled = false;
    Timer += Time.deltaTime;
    
    if (Timer < 4.8)
    {
    
    Camera.main.fieldOfView += 0.10f;

    }
      
    }
    }
    }
 
    

  
  
  

