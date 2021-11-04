using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearForceField : MonoBehaviour
{
    public GameObject objetoaclonar;
    public Transform puntosalida;
    public float tiempodeUso;
    private float inicioForceField;
    
public void starty2()
{
    inicioForceField = Time.time + tiempodeUso;
            GameObject objetoaclonarInstant = Instantiate( objetoaclonar, puntosalida.transform.position, puntosalida.transform.rotation, transform.parent = puntosalida) as GameObject;
            Rigidbody RBbala = objetoaclonarInstant.GetComponent<Rigidbody>();
            
            Destroy(objetoaclonarInstant,16.0f);

            if (this.gameObject.tag == "Player")
            {
            objetoaclonarInstant.gameObject.tag = "ForceFieldPlayer1"; 
            }
            

            if (this.gameObject.tag == "Player2")
            {
            objetoaclonarInstant.gameObject.tag = "ForceFieldPlayer2"; 
            }


            if (this.gameObject.tag == "Player3")
            {
            objetoaclonarInstant.gameObject.tag = "ForceFieldPlayer3"; 
            }


            if (this.gameObject.tag == "Player4")
            {
            objetoaclonarInstant.gameObject.tag = "ForceFieldPlayer4";   
}

    }
    
}