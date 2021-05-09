using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Island_Damage : MonoBehaviour
{
    public int cantidad = 100000;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<Life_And_Damage>().RestarVida(cantidad);
        }
    }
}
