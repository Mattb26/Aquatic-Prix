using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantieRandom : MonoBehaviour
{
    public Transform pos;
    public GameObject[] ObjetoInstanciar;
 
    // Start is called before the first frame update
    void Start()
    {
        InstantieObject();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void InstantieObject()
    {
        int n = Random.Range(5, ObjetoInstanciar.Length);
        Instantiate(ObjetoInstanciar[n], pos.position, ObjetoInstanciar[n].transform.rotation);
    }
}
