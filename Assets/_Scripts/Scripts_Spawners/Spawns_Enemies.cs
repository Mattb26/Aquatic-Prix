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
    public int tiempoSpawn = 3;
    public GameObject TheNewParent;
    private Enemy_Life enemyylifee;

[HideInInspector]
public float a = 0;


private SupervivenciaPuntaje GameControlador;
private EnemigosPuntaje GameControlador2;


    // Start is called before the first frame update
    void Start()
    {
        // Invokerepeating(nombre de la accion, tiempo inicial, cada cuanto se repite
        InvokeRepeating("spawn", 5, tiempoSpawn);
       enemyylifee = enemigo.GetComponent<Enemy_Life>();
        InvokeRepeating("spawn2", 1, 1);
      InvokeRepeating("spawn3", 1, 1);
        //GenerarEnemigos(3);
       

    }
    void Awake()
    {


    }
    // Update is called once per frame
    void Update()
    {
        

//GameControlador.b = dead_enemy;
//GameControlador.c = n_enemigos;
//GameControlador.d = tiempoSpawn;

        
        oleadas();
        if (oleada == 5 || oleada == 15 || oleada == 30)
        {
            if (a > 0)
            {
                enemyylifee.vida = enemyylifee.vida * 2;
                
                print("Enemigos, Vida x2");
                a = 0;
            }
        }
        if (oleada > 30)
        {
            if (a > 0)
            {
                enemyylifee.escudo = enemyylifee.escudo + 5;

                print("Enemigos, Mas escudo");
                a = 0;
            }
        }

        //  miunion.a = dead_enemy;


    }
    public void spawn()
    {
        //int i = Random.Range(0, 4);
        //Instantiate(enemigo, spawn_point[i].position, transform.rotation);
        //Instantiate(enemigo, spawn_point.position, transform.rotation);
        
        
            if (n_enemigos < enemigosAGenerar)
        {
            int i = Random.Range(0, 7);
            
            Instantiate(enemigo, spawn_point[i].position, transform.rotation, transform.parent = TheNewParent.transform);
            //enemigo.transform.parent = TheNewParent.transform
            //Instantiate(enemigo, spawn_point.position, transform.rotation);
            print("Enemigo Generado");
            n_enemigos = n_enemigos + 1;
           // GameControlador = GameObject.Find("Texto1").
            
        }
    }

        public void spawn2()
    {
       GameControlador = GameObject.Find("Texto1").GetComponent<SupervivenciaPuntaje>();
            GameControlador.oleadanumero = oleada;

    }

    public void spawn3()
    {
       GameControlador2 = GameObject.Find("Texto2").GetComponent<EnemigosPuntaje>();
            GameControlador2.enemigosadestruir = (n_enemigos - dead_enemy);

    }

    public void oleadas()
    {
        //         
        if (dead_enemy == enemigosAGenerar)
        {
            enemigosAGenerar = enemigosAGenerar + 1;
            oleada++;
            a++;
            print("Oleada Terminada");
            n_enemigos = enemigosAGenerar;
            dead_enemy = 0;
            n_enemigos = 0;
        }
    }
}