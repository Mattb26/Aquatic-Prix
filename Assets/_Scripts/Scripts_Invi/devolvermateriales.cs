using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class devolvermateriales : MonoBehaviour
{
    // Start is called before the first frame update
   
     //in the editor this is what you would set as the object you wan't to change
 

    public Material[] newMaterials;
    public Material[] oldMaterials;
    
    public float Timer;

    void Update()
    {
        Timer += Time.deltaTime;


       MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
        // Get the current material applied on this GameObject
        
        Material[] newMaterials = meshRenderer.materials;
        //print the material name in the console
        
        // Set the new material on the GameObject
       if (Timer > 14)
         {
            meshRenderer.materials = oldMaterials;
            Timer = 0;
    }
       
            
        

       
}}
     