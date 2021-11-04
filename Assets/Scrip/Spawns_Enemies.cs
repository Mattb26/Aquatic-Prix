using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Spawns_Enemies : MonoBehaviour
{
    [Header("Objetos de Spawn")]
    public Transform[] spawn_point;
    //public Transform spawn_point;
    public GameObject enemigo;
    [Header("Opciones de Oleadas")]
    public int n_enemigos = 0;
    public int dead_enemy = 0;
    public int enemigosAGenerar = 3;
    public int oleada = 1;
    public int tiempoSpawn = 1;
    public GameObject TheNewParent;
    private Enemy_Life aver;






    // Start is called before the first frame update
    void Start()
    {
        // Invokerepeating(nombre de la accion, tiempo inicial, cada cuanto se repite
        InvokeRepeating("spawn", 5, tiempoSpawn);
        //GenerarEnemigos(3);


    }
    void Awake()
    {

    }
    // Update is called once per frame
    void Update()
    {
        oleadas();

        //  miunion.a = dead_enemy;


    }
    void spawn()
    {
        //int i = Random.Range(0, 4);
        //Instantiate(enemigo, spawn_point[i].position, transform.rotation);
        //Instantiate(enemigo, spawn_point.position, transform.rotation);
        if (n_enemigos < enemigosAGenerar)
        {
            int i = Random.Range(0, 3);
            Instantiate(enemigo, spawn_point[i].position, transform.rotation, transform.parent = TheNewParent.transform);
            //enemigo.transform.parent = TheNewParent.transform
            //Instantiate(enemigo, spawn_point.position, transform.rotation);
            print("Enemigo Generado");
            n_enemigos = n_enemigos + 1;
        }

    }

    public void oleadas()
    {
        //         
        if (dead_enemy == enemigosAGenerar)
        {
            enemigosAGenerar = enemigosAGenerar + 1;
            oleada++;
            print("Oleada Terminada");
            n_enemigos = enemigosAGenerar;
            dead_enemy = 0;
            n_enemigos = 0;
        }
    }
}