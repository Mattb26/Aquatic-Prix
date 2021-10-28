using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changemesh : MonoBehaviour
{
    // Start is called before the first frame update
     public Material invisimaterial;
     
 public Material normal;
 public Material normal2;
 public Material normal3;
 public Material normal4;
 public Material normal5;
 public Material normal6;
 public Material normal7;
  public Material normal8;
   public Material normal9;
    public Material normal10;
 
     // Use this for initialization
     void Start () {
        
         
         this.gameObject.GetComponent<Renderer>().sharedMaterial = invisimaterial;



}
}
