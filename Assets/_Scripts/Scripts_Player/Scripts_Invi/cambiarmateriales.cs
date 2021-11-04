using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cambiarmateriales : MonoBehaviour
{
     //in the editor this is what you would set as the object you wan't to change
    public Material[] oldMaterials;
    public Material[] newMaterials;
   
public void cambiar()
{       
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
        // Get the current material applied on this GameObject
        Material[] oldMaterials = meshRenderer.materials;
        meshRenderer.materials = newMaterials;
        cambioDeLayerHaciaInvisible();
    }

public void cambioDeLayerHaciaInvisible()
 {
      if (this.gameObject.tag == "Player")  
      {
          this.gameObject.layer = 6;
      }
      if (this.gameObject.tag == "Player2")  
      {
          this.gameObject.layer = 7;
      }
      if (this.gameObject.tag == "Player3")  
      {
          this.gameObject.layer = 8;
      }
      if (this.gameObject.tag == "Player4")  
      {
          this.gameObject.layer = 9;
      }

 }

}