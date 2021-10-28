using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructible : MonoBehaviour
{
    
    
    void Start() 
     {
       GetComponent<Rigidbody>().AddExplosionForce(500, transform.position, 555);   //Adds an explosion
            
     }
   

}

