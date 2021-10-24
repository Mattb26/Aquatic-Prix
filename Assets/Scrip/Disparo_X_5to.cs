using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo_X_5to : MonoBehaviour
{
    public GameObject objetoaclonar;
    public Transform puntosalida;
    public Transform puntosalida2;
    public Transform puntosalida3;
    public Transform puntosalida4;
    public Transform puntosalida5;
    public Transform puntosalida6;
    public Transform puntosalida7;
    public Transform puntosalida8;
    public Transform puntosalida9;
    public Transform puntosalida10;
    public float velocidadDisparo;
    public float tiempoDisparo;
    private float inicioDisparo;
    private float inicioDisparo2;
    private float inicioDisparo3;
    private float inicioDisparo4;
    private float inicioDisparo5;
    private float inicioDisparo6;
    private float inicioDisparo7;
    private float inicioDisparo8;
    private float inicioDisparo9;
    private float inicioDisparo10;
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
                        else
                        {
                            if (Input.GetButtonDown("Fire1") && Time.time > inicioDisparo5)
                            {
                                inicioDisparo5 = Time.time + tiempoDisparo;

                                GameObject objetoaclonarInstant = Instantiate(objetoaclonar, puntosalida5.transform.position, puntosalida5.transform.rotation) as GameObject;
                                Rigidbody RBbala = objetoaclonarInstant.GetComponent<Rigidbody>();
                                RBbala.AddForce(puntosalida5.forward * 1000 * velocidadDisparo);
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
        }
        else
        {
            if (Input.GetButtonDown("Fire1") && Time.time > inicioDisparo6)
            {
                inicioDisparo6 = Time.time + tiempoDisparo;

                GameObject objetoaclonarInstant = Instantiate(objetoaclonar, puntosalida6.transform.position, puntosalida6.transform.rotation) as GameObject;
                Rigidbody RBbala = objetoaclonarInstant.GetComponent<Rigidbody>();
                RBbala.AddForce(puntosalida6.forward * 1000 * velocidadDisparo);
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
                if (Input.GetButtonDown("Fire1") && Time.time > inicioDisparo7)
                {
                    inicioDisparo7 = Time.time + tiempoDisparo;

                    GameObject objetoaclonarInstant = Instantiate(objetoaclonar, puntosalida7.transform.position, puntosalida7.transform.rotation) as GameObject;
                    Rigidbody RBbala = objetoaclonarInstant.GetComponent<Rigidbody>();
                    RBbala.AddForce(puntosalida7.forward * 1000 * velocidadDisparo);
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
                    if (Input.GetButtonDown("Fire1") && Time.time > inicioDisparo8)
                    {
                        inicioDisparo8 = Time.time + tiempoDisparo;

                        GameObject objetoaclonarInstant = Instantiate(objetoaclonar, puntosalida8.transform.position, puntosalida8.transform.rotation) as GameObject;
                        Rigidbody RBbala = objetoaclonarInstant.GetComponent<Rigidbody>();
                        RBbala.AddForce(puntosalida8.forward * 1000 * velocidadDisparo);
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
                        if (Input.GetButtonDown("Fire1") && Time.time > inicioDisparo9)
                        {
                            inicioDisparo9 = Time.time + tiempoDisparo;

                            GameObject objetoaclonarInstant = Instantiate(objetoaclonar, puntosalida9.transform.position, puntosalida9.transform.rotation) as GameObject;
                            Rigidbody RBbala = objetoaclonarInstant.GetComponent<Rigidbody>();
                            RBbala.AddForce(puntosalida9.forward * 1000 * velocidadDisparo);
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
                            if (Input.GetButtonDown("Fire1") && Time.time > inicioDisparo10)
                            {
                                inicioDisparo10 = Time.time + tiempoDisparo;

                                GameObject objetoaclonarInstant = Instantiate(objetoaclonar, puntosalida10.transform.position, puntosalida10.transform.rotation) as GameObject;
                                Rigidbody RBbala = objetoaclonarInstant.GetComponent<Rigidbody>();
                                RBbala.AddForce(puntosalida10.forward * 1000 * velocidadDisparo);
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
        }
    }
}
