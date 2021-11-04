using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class togglebarco : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject EstadisticaBarco;
    public GameObject Barco;
    void Awake()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Barco.activeSelf == true)
        {
           EstadisticaBarco.SetActive(true);
        }
        if (Barco.activeSelf == false)
        {
        EstadisticaBarco.SetActive(false);
        }

        
    }
}
