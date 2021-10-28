using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SeeThrough : MonoBehaviour
{
  public float a = 0f;
  public float b = 0f;



  void Update() 
  {
       Material material = this.gameObject.GetComponent<Renderer>().sharedMaterial;
       material.SetInt("_SmoothnessTextureChannel", 1);
       material.SetFloat("_Metallic", b);
       material.SetFloat("_GlossMapScale", a);
       
  }
 
private void Start()
 {
     StartCoroutine(ChangeColors());
     StartCoroutine(ChangeColors2());
 }
 
 private IEnumerator ChangeColors()
 {
       while (a >= 0 && a <= 0.1f)
     {   
         a = 0.02f;
         yield return new WaitForSeconds(0.1f);
         a = 0.04f;
         yield return new WaitForSeconds(0.1f);
         a = 0.06f;
         yield return new WaitForSeconds(0.1f);
         a = 0.08f;
         yield return new WaitForSeconds(0.1f);
         a = 0.10f;
         yield return new WaitForSeconds(0.1f);
         a = 0.12f;
         yield return new WaitForSeconds(0.1f);
         a = 0.14f;
         yield return new WaitForSeconds(0.1f);
         a = 0.16f;
         yield return new WaitForSeconds(0.1f); 
         a = 0.18f;
         yield return new WaitForSeconds(0.1f); 
         a = 0.20f;
         yield return new WaitForSeconds(0.1f);
         a = 0.22f;
         yield return new WaitForSeconds(0.1f);
         a = 0.24f;
         yield return new WaitForSeconds(0.1f);
         a = 0.26f;
         yield return new WaitForSeconds(0.1f);
         a = 0.28f;
         yield return new WaitForSeconds(0.1f);
         a = 0.30f;
         yield return new WaitForSeconds(0.1f);
         a = 0.28f;
         yield return new WaitForSeconds(0.1f);
         a = 0.26f;
         yield return new WaitForSeconds(0.1f);
         a = 0.24f;
         yield return new WaitForSeconds(0.1f);
         a = 0.22f;
         yield return new WaitForSeconds(0.1f);
         a = 0.20f;
         yield return new WaitForSeconds(0.1f);
         a = 0.18f;
         yield return new WaitForSeconds(0.1f);
         a = 0.16f;
         yield return new WaitForSeconds(0.1f);
         a = 0.14f;
         yield return new WaitForSeconds(0.1f);
         a = 0.12f;
         yield return new WaitForSeconds(0.1f);
         a = 0.10f;
         yield return new WaitForSeconds(0.1f);
         a = 0.08f;
         yield return new WaitForSeconds(0.1f);
         a = 0.06f;
         yield return new WaitForSeconds(0.1f);
         a = 0.04f;
         yield return new WaitForSeconds(0.1f);
         a = 0.02f;
         yield return new WaitForSeconds(0.1f);
         a = 0f;
         yield return new WaitForSeconds(0.1f);






     }}

private IEnumerator ChangeColors2()
{
     while (b >= 0 && b <= 0.1f)
         {   
         b = 0.02f;
         yield return new WaitForSeconds(0.1f);
         b = 0.04f;
         yield return new WaitForSeconds(0.1f);
         b = 0.06f;
         yield return new WaitForSeconds(0.1f);
         b = 0.08f;
         yield return new WaitForSeconds(0.1f);
         b = 0.10f;
         yield return new WaitForSeconds(0.1f);
         b = 0.12f;
         yield return new WaitForSeconds(0.1f);
         b = 0.14f;
         yield return new WaitForSeconds(0.1f);
         b = 0.16f;
         yield return new WaitForSeconds(0.1f); 
         b = 0.18f;
         yield return new WaitForSeconds(0.1f); 
         b = 0.20f;
         yield return new WaitForSeconds(0.1f);
         b = 0.22f;
         yield return new WaitForSeconds(0.1f);
         b = 0.24f;
         yield return new WaitForSeconds(0.1f);
         b = 0.26f;
         yield return new WaitForSeconds(0.1f);
         b = 0.28f;
         yield return new WaitForSeconds(0.1f);
         b = 0.30f;
         yield return new WaitForSeconds(0.1f);
         b = 0.28f;
         yield return new WaitForSeconds(0.1f);
         b = 0.26f;
         yield return new WaitForSeconds(0.1f);
         b = 0.24f;
         yield return new WaitForSeconds(0.1f);
         b = 0.22f;
         yield return new WaitForSeconds(0.1f);
         b = 0.20f;
         yield return new WaitForSeconds(0.1f);
         b = 0.18f;
         yield return new WaitForSeconds(0.1f);
         b = 0.16f;
         yield return new WaitForSeconds(0.1f);
         b = 0.14f;
         yield return new WaitForSeconds(0.1f);
         b = 0.12f;
         yield return new WaitForSeconds(0.1f);
         b = 0.10f;
         yield return new WaitForSeconds(0.1f);
         b = 0.08f;
         yield return new WaitForSeconds(0.1f);
         b = 0.06f;
         yield return new WaitForSeconds(0.1f);
         b = 0.04f;
         yield return new WaitForSeconds(0.1f);
         b = 0.02f;
         yield return new WaitForSeconds(0.1f);
         b = 0f;
         yield return new WaitForSeconds(0.1f);
     }
}
 }

 










