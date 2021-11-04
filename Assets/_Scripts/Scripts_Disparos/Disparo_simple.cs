using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo_simple : MonoBehaviour
{
    public GameObject objetoaclonar;
    
    public Transform puntosalida;
    public float velocidadDisparo;
    public float tiempoDisparo;
    private float inicioDisparo;
    private GameObject gameObjectFoundBySearch;
    void Start()
    {
    }

    void Update()
    {
        if( Input.GetButtonDown("Fire1") && Time.time > inicioDisparo) 
        {
           
            // Instantiate(objetoaclonar, puntosalida.position, puntosalida.rotation, Transform parent)
            inicioDisparo = Time.time + tiempoDisparo;

            GameObject objetoaclonarInstant = Instantiate( objetoaclonar, puntosalida.transform.position, puntosalida.transform.rotation) as GameObject;
            
            Rigidbody RBbala = objetoaclonarInstant.GetComponent<Rigidbody>();
            RBbala.AddForce(puntosalida.forward * 1000 * velocidadDisparo);
            Destroy(objetoaclonarInstant,3.0f);


            if (this.gameObject.tag == "Player")
            {
            objetoaclonarInstant.gameObject.tag = "BulletPlayer1"; 
            }


            if (this.gameObject.tag == "Player2")
            {
            objetoaclonarInstant.gameObject.tag = "BulletPlayer2"; 
            }


            if (this.gameObject.tag == "Player3")
            {
            objetoaclonarInstant.gameObject.tag = "BulletPlayer3"; 
            }


            if (this.gameObject.tag == "Player4")
            {
            objetoaclonarInstant.gameObject.tag = "BulletPlayer4"; 
            } 
            
           


 
         } 
    }
}