using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateSpawner : MonoBehaviour
{
    public GameObject objetoaclonar;
    public Transform puntosalida;
 
    void Start()
    {
        GameObject objetoaclonarInstant = Instantiate( objetoaclonar, puntosalida.transform.position, puntosalida.transform.rotation) as GameObject;
    }

    void Update()
    {
        
       
    }
}
