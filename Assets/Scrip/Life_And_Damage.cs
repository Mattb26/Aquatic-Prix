using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life_And_Damage : MonoBehaviour
{
    public int vida;

    public void RestarVida(int cantidad)
    {
        vida -= cantidad;
    }
    
}
