using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cambiarmateriales : MonoBehaviour
{
    // Start is called before the first frame update
   
     //in the editor this is what you would set as the object you wan't to change
 
    public Material[] oldMaterials;
    public Material[] newMaterials;
    
    public float Timer;

    void Update()
    {
        Timer += Time.deltaTime;


       MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
        // Get the current material applied on this GameObject
        Material[] oldMaterials = meshRenderer.materials;
        
        //print the material name in the console
        
        // Set the new material on the GameObject
       
         if (Timer > 8)
         {
            meshRenderer.materials = newMaterials;
            Timer = 0;
    }

            
           
            
        

       
}

          public void cambiar()
          {
              
          }

}
     





