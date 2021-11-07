using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPowerUps : MonoBehaviour
{
    // Start is called before the first frame update
public GameObject[] spawnObjects;
public Transform[] spawnLocations;
    public int tiempo;
    public int objetoinstanciados = 0;
    public int tiemponormal;
    void Start()
    {
        tiemponormal = tiempo;
        InvokeRepeating("instaa", 5.0f, tiempo);
    }
    private void Update()
    {
        if (objetoinstanciados >= 20)
        {
            tiempo = 0;
        }
        else if (tiempo == 0 && objetoinstanciados <=20)
        {
            tiempo = tiemponormal;
        }
    }

    // public void instaa() 
    //    {
    //for (int i = 0; i< spawnLocations.Length; i++)
    //    { 
    //      // Instantiate(spawnObjects[Random.Range(0,spawnObjects.Length)], spawnLocations[Random.Range(0,spawnLocations.Length)]);
    //      Instantiate(spawnObjects[Random.Range(0,spawnObjects.Length)], spawnLocations[i]);
    //    }
    //       // if (other.gameObject.tag == "HealthPowerUp" || other.gameObject.tag == "ShieldPowerUp" || other.gameObject.tag == "SpeedPowerUp"|| other.gameObject.tag == "InvisiblePowerUp" || other.gameObject.tag == "ForceFieldPowerUp")
    //      // Find.game
    //     // if(transform.childCount > 0)
    //    }

    //    //Vector3 A(mibarco) = actualposition (15,15,0)
    //    //Vector3 B(MiPowerUp) = actualposition (5,5,5)

    //    //Vector3 C = A - B
    //    //cosas mati
    public void instaa()
    {
        if (tiempo > 0)
        {
            for (int i = 0; i < spawnLocations.Length; i++)
            {
                Instantiate(spawnObjects[Random.Range(0, spawnObjects.Length)], spawnLocations[i]);
                objetoinstanciados = objetoinstanciados + 1;
            }
        }
        
    }
}
