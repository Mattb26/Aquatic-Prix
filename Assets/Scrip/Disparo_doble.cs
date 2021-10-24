using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo_doble : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject objetoaclonar;
    public Transform puntosalida;
    public Transform puntosalida2;
    public float velocidadDisparo;
    public float tiempoDisparo;
    private float inicioDisparo;
    private float inicioDisparo2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && Time.time > inicioDisparo)
        {
            // Instantiate(objetoaclonar, puntosalida.position, puntosalida.rotation)
            inicioDisparo = Time.time + tiempoDisparo;

            GameObject objetoaclonarInstant = Instantiate(objetoaclonar, puntosalida.transform.position, puntosalida.transform.rotation) as GameObject;
            Rigidbody RBbala = objetoaclonarInstant.GetComponent<Rigidbody>();
            RBbala.AddForce(puntosalida.forward * 1000 * velocidadDisparo);
            Destroy(objetoaclonarInstant, 3.0f);

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
        else
        {
            if(Input.GetButtonDown("Fire1") && Time.time > inicioDisparo2)
            {
                inicioDisparo2 = Time.time + tiempoDisparo;

                GameObject objetoaclonarInstant = Instantiate(objetoaclonar, puntosalida2.transform.position, puntosalida2.transform.rotation) as GameObject;
                Rigidbody RBbala = objetoaclonarInstant.GetComponent<Rigidbody>();
                RBbala.AddForce(puntosalida2.forward * 1000 * velocidadDisparo);
                Destroy(objetoaclonarInstant, 3.0f);

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
}
