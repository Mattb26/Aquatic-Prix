using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo_X_Doble : MonoBehaviour
{
    public GameObject objetoaclonar;
    public Transform puntosalida;
    public Transform puntosalida2;
    public Transform puntosalida3;
    public Transform puntosalida4;
    public float velocidadDisparo;
    public float tiempoDisparo;
    private float inicioDisparo;
    private float inicioDisparo2;
    private float inicioDisparo3;
    private float inicioDisparo4;
    public bool cambiolado;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("CambioVista") && cambiolado == false)
        {
            cambiolado = true;
        }
        else
        {
            if (Input.GetButtonDown("CambioVista") && cambiolado == true)
            {
                cambiolado = false;
            }
        }
        if (!cambiolado)
        {
            if (Input.GetButtonDown("Fire1") && Time.time > inicioDisparo)
            {
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
                if (Input.GetButtonDown("Fire1") && Time.time > inicioDisparo2)
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
        else
        {
            if (Input.GetButtonDown("Fire1") && Time.time > inicioDisparo3)
            {
                inicioDisparo3 = Time.time + tiempoDisparo;

                GameObject objetoaclonarInstant = Instantiate(objetoaclonar, puntosalida3.transform.position, puntosalida3.transform.rotation) as GameObject;
                Rigidbody RBbala = objetoaclonarInstant.GetComponent<Rigidbody>();
                RBbala.AddForce(puntosalida3.forward * 1000 * velocidadDisparo);
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
                if (Input.GetButtonDown("Fire1") && Time.time > inicioDisparo4)
                {
                    inicioDisparo4 = Time.time + tiempoDisparo;

                    GameObject objetoaclonarInstant = Instantiate(objetoaclonar, puntosalida4.transform.position, puntosalida4.transform.rotation) as GameObject;
                    Rigidbody RBbala = objetoaclonarInstant.GetComponent<Rigidbody>();
                    RBbala.AddForce(puntosalida4.forward * 1000 * velocidadDisparo);
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
}
