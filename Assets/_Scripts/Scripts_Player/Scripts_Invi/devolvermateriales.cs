using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class devolvermateriales : MonoBehaviour
{     
    //in the editor this is what you would set as the object you wan't to change
    public Material[] newMaterials;
    public Material[] oldMaterials;

 [HideInInspector] 
    public float tiempoDuracion = 0;

    void FixedUpdate()
    {
       
    }

  
public void devolver()
    {
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
        // Get the current material applied on this GameObject
        Material[] newMaterials = meshRenderer.materials;
        meshRenderer.materials = oldMaterials;  
        cambioDeLayerHaciaVisible();
    }

    public void dothething()
    {
  Invoke("devolver", tiempoDuracion);
    }
    public void cambioDeLayerHaciaVisible()
 {
      if (this.gameObject.tag == "Player")  
      {
          this.gameObject.layer = 0;
      }
      if (this.gameObject.tag == "Player2")  
      {
          this.gameObject.layer = 0;
      }
      if (this.gameObject.tag == "Player3")  
      {
          this.gameObject.layer = 0;
      }
      if (this.gameObject.tag == "Player4")  
      {
          this.gameObject.layer = 0;
      }

 }
}