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
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    
    void Update()
    {
        if( Input.GetButtonDown("Fire1") && Time.time > inicioDisparo) 
        {
            // Instantiate(objetoaclonar, puntosalida.position, puntosalida.rotation)
            inicioDisparo = Time.time + tiempoDisparo;

            GameObject objetoaclonarInstant = Instantiate(objetoaclonar, puntosalida.transform.position, puntosalida.transform.rotation) as GameObject;
            Rigidbody RBbala = objetoaclonarInstant.GetComponent<Rigidbody>();
            RBbala.AddForce(puntosalida.forward * 1000 * velocidadDisparo);
            Destroy(objetoaclonarInstant,3.0f);

        }
    }
}
