using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps_Cont : MonoBehaviour
{
    public int contador = 1;
    private SpawnPowerUps objetoinstanciado;
    public GameObject power;

    public void Start()
    {
        objetoinstanciado = power.GetComponent<SpawnPowerUps>();
    }
    public void OnTriggerEnter(Collider other)
    {
        print("Hola");
        objetoinstanciado.objetoinstanciados = objetoinstanciado.objetoinstanciados - 1;
    }
}
