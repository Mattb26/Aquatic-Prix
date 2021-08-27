using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class Life_And_Damage : MonoBehaviour
{
    public float vida;
    public Image barravida;

    void Update()
    {
        vida = Mathf.Clamp(vida, 0, 10000);
        barravida.fillAmount = vida/ 100;
    }
    public void RestarVida(int cantidad)
    {
        vida -= cantidad;
    }

    public void OnTriggerEnter(Collider other)
    {
    
        if (other.tag == "HealthPowerUp")
        {
            
            vida = vida + 100.0f;
            Destroy(other.gameObject);
        }


    }




}
