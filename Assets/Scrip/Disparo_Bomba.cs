using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo_Bomba : MonoBehaviour
{
    public Rigidbody objetoaclonar;
    public Transform puntosalida;
    public float tiempoDisparo;
    private float inicioDisparo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Bomba") && Time.time > inicioDisparo)
        {
            inicioDisparo = Time.time + tiempoDisparo;
            Rigidbody objetoaclonarInstant;
            objetoaclonarInstant = Instantiate(objetoaclonar, puntosalida.position, Quaternion.identity) as Rigidbody;
        }

    }
}
