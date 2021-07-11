using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo_Bomba : MonoBehaviour
{
    public GameObject objetoaclonar;
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
            GameObject objetoaclonarInstant = Instantiate(objetoaclonar, puntosalida.transform.position, puntosalida.transform.rotation) as GameObject;
            Destroy(objetoaclonarInstant, 5.0f);
        }

    }
}
