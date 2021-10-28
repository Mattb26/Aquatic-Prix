using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceField : MonoBehaviour
{
public float maxSize;
public float growFactor;
public float waitTime;
     
      public void Start()
      {
          StartCoroutine(Scale()); 
      }
  
    IEnumerator Scale()
    {                                           
        float timer = 0;
        
        while(true)  
        { 
        while(maxSize > transform.localScale.x)
        {
          
        timer += Time.deltaTime;
        transform.localScale += new Vector3(1, 1, 1) * Time.deltaTime * growFactor;
        
        yield return null; //Reset the timer.
        }
        
        yield return new WaitForSeconds(4);

        timer = 0;
        while(1 < transform.localScale.x)
        {
         
        timer += Time.deltaTime;
        transform.localScale -= new Vector3(1, 1, 1) * Time.deltaTime * growFactor;
        
        yield return null;
        timer = 0;
        } 
        } 
    }



public void OnTriggerEnter(Collider other)
{

  if (this.gameObject.tag == "ForceFieldPlayer1")
  {
if ((other.gameObject.tag == "BulletPlayer2") || (other.gameObject.tag == "BulletPlayer3") || (other.gameObject.tag == "BulletPlayer4") || (other.gameObject.tag == "EnemyBullet"))
  {
  Destroy(other.gameObject);
  }
  }

if (this.gameObject.tag == "ForceFieldPlayer2")
  {
if ((other.gameObject.tag == "BulletPlayer1") || (other.gameObject.tag == "BulletPlayer3") || (other.gameObject.tag == "BulletPlayer4") || (other.gameObject.tag == "EnemyBullet"))
  {
  Destroy(other.gameObject);
  }
  }

if (this.gameObject.tag == "ForceFieldPlayer3")
  {
if ((other.gameObject.tag == "BulletPlayer1") || (other.gameObject.tag == "BulletPlayer2") || (other.gameObject.tag == "BulletPlayer4") || (other.gameObject.tag == "EnemyBullet"))
  {
  Destroy(other.gameObject);
  }
  }

if (this.gameObject.tag == "ForceFieldPlayer4")
  {
if ((other.gameObject.tag == "BulletPlayer1") || (other.gameObject.tag == "BulletPlayer2") || (other.gameObject.tag == "BulletPlayer3") || (other.gameObject.tag == "EnemyBullet"))
  {
  Destroy(other.gameObject);
  }
  }

}

}
