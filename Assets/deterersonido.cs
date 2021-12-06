using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deterersonido : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     public void prendersonido()
     {
       AudioListener.pause = false;
     }

     public void apagarsonido()
     {
       AudioListener.pause = true;
     }
}
