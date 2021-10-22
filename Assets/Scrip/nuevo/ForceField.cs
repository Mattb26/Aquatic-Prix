using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceField : MonoBehaviour
{


public float maxSize;
public float growFactor;

public float waitTime;
[HideInInspector]
public float duracionPowerUpForceShield;

 void Update() 
    {

    }
      public void Awake()
      {
        
          StartCoroutine(Scale()); 
         timer();
       
      }
  
     public void timer()
     {
       duracionPowerUpForceShield -= Time.deltaTime;
      Debug.Log(duracionPowerUpForceShield);
     if (duracionPowerUpForceShield < 0) 
     {
       duracionPowerUpForceShield = 0;
       transform.localScale = new Vector3(1, 1, 1);
       this.gameObject.SetActive(false);
      }
       
     }

    IEnumerator Scale()
    {   
        
        //waitTime = duracion / 4;
        //duracionPowerUpForceShield -= Time.deltaTime;                                          
        float timer = 0;
        
        //We make a timer, give it value of zero, named it timer.
        while(true)   //Kinda like, if its on or off.
        { //we scale ALLLLL the axis, so that they will hve the same value, so we can work with a float instead of comparing vectors.
        while(maxSize > transform.localScale.x) //the public float we made before)//>
        {
          
        timer += Time.deltaTime;
        transform.localScale += new Vector3(1, 1, 1) * Time.deltaTime * growFactor;
        
        
        yield return null; //Reset the timer.
        }
        Debug.Log("A ver... que pasa con el valor del timer: " + duracionPowerUpForceShield);  
        //yield return new WaitForSeconds(waitTime);

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
  if (transform.parent != null && transform.parent.tag == "Player")
  {
if ((other.gameObject.tag == "BulletPlayer2") || (other.gameObject.tag == "BulletPlayer2") || (other.gameObject.tag == "BulletPlayer4"))
  {
  Destroy(other.gameObject);
  }
  }

if (transform.parent != null && transform.parent.tag == "Player2")
  {
if ((other.gameObject.tag == "BulletPlayer1") || (other.gameObject.tag == "BulletPlayer3") || (other.gameObject.tag == "BulletPlayer4"))
  {
  Destroy(other.gameObject);
  }
  }

if (transform.parent != null && transform.parent.tag == "Player3")
  {
if ((other.gameObject.tag == "BulletPlayer1") || (other.gameObject.tag == "BulletPlayer2") || (other.gameObject.tag == "BulletPlayer4"))
  {
  Destroy(other.gameObject);
  }
  }

if (transform.parent != null && transform.parent.tag == "Player4")
  {
if ((other.gameObject.tag == "BulletPlayer1") || (other.gameObject.tag == "BulletPlayer2") || (other.gameObject.tag == "BulletPlayer3"))
  {
  Destroy(other.gameObject);
  }
  }
}
}







//if... bullet initialposition=0,0,0
 //   public void OnTriggerEnter(Collider other)
  //  {
    //col.tag == "Bullet" && 
    //    if(other.tag == "Bullet") {
    //    if(!other.transform.IsChildOf(targetParent))
    //    {
    //         Destroy(other.gameObject);
    //    }
   //     }

//startPos = targetbullet.transform.position;

//if (startPos == (0,0,0))
//{

//}

//if(other.tag == "Bullet")


//I need for the shield to destroy the ENEMY bullets, and not my own. and for my own bullets to not damage




    
      // else if(other.tag == "Missile")
      //   {
      //       Destroy(other.gameObject);
      //   }

      



    
    
    





