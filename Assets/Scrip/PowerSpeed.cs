using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerSpeed : MonoBehaviour
{
    public float multiplier = 4f;
    public GameObject pickupEffect;
    public float duracion = 3f;
    
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            StartCoroutine(PickUp(other)  );
        }
    }


    
    IEnumerator PickUp( Collider player)
    {
        Instantiate(pickupEffect, transform.position, transform.rotation);
        shipsMove speed = player.GetComponent<shipsMove>();
        speed.playerspeed = 400;

       
        

        yield return new WaitForSeconds(duracion);

        speed.playerspeed = 100f;
        

        Destroy(gameObject);
        

    }
}
