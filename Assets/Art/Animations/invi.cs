using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invi : MonoBehaviour
{
    public float aFloat = 0;
    public float bFloat = 0;
   
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Material material = this.gameObject.GetComponent<Renderer>().sharedMaterial;
        material.SetFloat("_Metallic", aFloat);
   
        material.SetFloat("_GlossMapScale", bFloat);
        pruebaa();
    }

void pruebaa()
{
    if (aFloat < 0.5)
    {
        aFloat += 0.003f;
    }
    else {
        aFloat = 0;
    }

    if (bFloat < 0.5)
    {
        bFloat += 0.003f;
    }
    else {
        bFloat = 0;
    }
}

}
