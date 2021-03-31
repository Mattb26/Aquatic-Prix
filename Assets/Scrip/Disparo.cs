using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    public Rigidbody objetoaclonar;
    public Transform puntosalida;
    public float velocidadDisparo;
    public float tiempoDisparo;
    private float inicioDisparo;
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    public void destruir()
    {
        Destroy(gameObject);
    }
    void Update()
    {
        if( Input.GetButtonDown("Fire1") && Time.time > inicioDisparo) 
        {
            // Instantiate(objetoaclonar, puntosalida.position, puntosalida.rotation)
            inicioDisparo = Time.time + tiempoDisparo;
            Rigidbody objetoaclonarInstant;
            objetoaclonarInstant = Instantiate(objetoaclonar, puntosalida.position, Quaternion.identity) as Rigidbody;
            objetoaclonarInstant.AddForce(puntosalida.forward * 100 * velocidadDisparo);
            Invoke("destruir", 5);

        }
    }
}
