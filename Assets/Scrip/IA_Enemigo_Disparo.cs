using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class IA_Enemigo_Disparo : MonoBehaviour
{
    [Header("Ajustes")]
    //public int tiempo;
    public float speed;
    //bool Tiempodegiro;
    //float y;
    //otra configuracion
    public int rutina;
    public float cronometro;
    public Quaternion angulo;
    public float grado;
    [Header("Ajustes Disparos")]
    public Transform target;
    public Transform weapon;
    public GameObject objetoaclonar;
    public float velocidadDisparo = 10f;
    public float shootDistance = 10f;
    public float shootInterval = 2f;
    public float distancePlayer;
    float shootTime;
    float distanceToTarget;
    [Header("Ajustes Estados")]
    public bool ataque;
    public bool Espera;
    public int Estado = 1;
    NavMeshAgent agent;

    



    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        shootTime = shootInterval;
    }

    void Update()
    {
        //tiempo += 1;
        if(Estado == 1)
        {
            Espera = true;
            ataque = false;
        }
        else if(Estado == 2)
        {
            Espera = false;
            ataque = true;
        }
        //Codigo de prueba de alteracion de estados, si no funciona desactivar el modo espera
        if (Espera == true)
        {

            if (Vector3.Distance(GameObject.FindGameObjectWithTag("Player").transform.position, transform.position) <= distancePlayer)
            {
                Estado = 2;
            }
            RutinaEnemigo();
            //transform.Translate(transform.forward * speed * Time.fixedDeltaTime);
            //transform.Rotate(new Vector3(0, y, 0));
            //if (tiempo >= Random.Range(10, 50))
            //{
            //    Girar();
            //    tiempo = 0;
            //    Tiempodegiro = true;
            //}
            //if (Tiempodegiro == true)
            //{
            //    if (tiempo >= Random.Range(100, 200))
            //        y = 0;
            //    Tiempodegiro = false;
            //}
        }
        else if (ataque == true)
        {

            agent.SetDestination(GameObject.FindGameObjectWithTag("Player").transform.position);
            if (Vector3.Distance(GameObject.FindGameObjectWithTag("Player").transform.position, transform.position) > distancePlayer)
            {
                Estado = 1;
            }
            //El siguiente codigo funciona por localizacion por Objetivo
            //Vector3 posNoRot = new Vector3(target.position.x, 0.0f, target.position.z);
            //transform.LookAt(posNoRot);
            //distanceToTarget = Vector3.Distance(transform.position, target.position);
            //if (Vector3.Distance(target.transform.position, transform.position) < distancePlayer)
            //{
            //    agent.SetDestination(target.transform.position);
            //}
            //ShootControl();
            //Vector3 posNoRot = new Vector3(target.position.x, 0.0f, target.position.z);
            //El siguiente codigo funciona por localizacion por tag
            Vector3 posNoRot = new Vector3(GameObject.FindGameObjectWithTag("Player").transform.position.x, 0.0f, GameObject.FindGameObjectWithTag("Player").transform.position.z);
            transform.LookAt(posNoRot);
            distanceToTarget = Vector3.Distance(transform.position, GameObject.FindGameObjectWithTag("Player").transform.position);
            if (Vector3.Distance(GameObject.FindGameObjectWithTag("Player").transform.position, transform.position) < distancePlayer)
            {
                agent.SetDestination(GameObject.FindGameObjectWithTag("Player").transform.position);
            }
            ShootControl();
        }


    }
    // Codigo de prueba de alteracion de estados, si no funciona desactivar el modo espera
    //void Girar()
    //{
    //    y = Random.Range(-3, 3);
    //}
    // Control del disparo del enemigo
    void ShootControl()
    {
        shootTime -= Time.deltaTime;
        if(shootTime < 0)
        {
            if(distanceToTarget < shootDistance)
            {
                shootTime = shootInterval;
                GameObject objetoaclonarInstant = Instantiate(objetoaclonar, weapon.transform.position, weapon.transform.rotation) as GameObject;
                Rigidbody RBbala = objetoaclonarInstant.GetComponent<Rigidbody>();
                RBbala.AddForce(weapon.forward * 1000 * velocidadDisparo);
                Destroy(objetoaclonarInstant, 3.0f);

                if (this.gameObject.tag == "Enemy")
            {
            objetoaclonarInstant.gameObject.tag = "EnemyBullet"; 
            }
            }
            
        }
 

    }

    void RutinaEnemigo()
    {
        cronometro += 1 * Time.deltaTime;
        if (cronometro >= 4)
        {
            rutina = Random.Range(0, 1);
            cronometro = 0;
        }
        switch (rutina)
        {
            case 0:
                grado = Random.Range(0, 360);
                angulo = Quaternion.Euler(0, grado, 0);
                rutina++;
                break;
            case 1:
                transform.rotation = Quaternion.RotateTowards(transform.rotation, angulo, 0.5f);
                transform.Translate(Vector3.forward * speed * Time.deltaTime);
                break;
        }
    }
}
