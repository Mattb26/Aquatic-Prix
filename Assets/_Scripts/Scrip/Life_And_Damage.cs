using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class Life_And_Damage : MonoBehaviour
{
public Transform destroyedVersion;
    public float vida;
    public float vidaMaxima;
   
    public float escudo;
    public float escudoMaximo;
     public int DamageIsland;
    public int DamageBullet;
    public int DamageMissile;

     
    public Image barravida;
     
    public Image barraescudo;
   

   // private Invulnerable invulnerable;

    void Update()
    {
        vida = Mathf.Clamp(vida, 0, 10000);           
        barravida.fillAmount = vida/vidaMaxima;
        
        
        escudo = Mathf.Clamp(escudo, 0, 10000);
        barraescudo.fillAmount = escudo/escudoMaximo;

      //  invulnerable = GetComponent<Invulnerable>();
       if (vida == 0)
       {
           GetComponent<Rigidbody>().AddExplosionForce(50, transform.position, 55);
           Destroy(this.gameObject, 0f);
           Instantiate(destroyedVersion, transform.position, transform.rotation);
           
       }
    }
    public void RestarVida(float cantidadvida)
    {
        vida -= cantidadvida;
        
    }  

  public void RestarEscudo(float cantidadescudo)
    {
        escudo -= cantidadescudo;
    }

    





private void OnTriggerEnter(Collider other) {
{
if (this.gameObject.tag == "Player")
{
if ((other.gameObject.tag == "BulletPlayer2") || (other.gameObject.tag == "BulletPlayer3") || (other.gameObject.tag == "BulletPlayer4") || (other.gameObject.tag == "EnemyBullet"))
{
if (escudo == 0) {
RestarVida(DamageBullet);
 }
     if ((DamageBullet > escudo && escudo > 0)) 
     {
           float NewEscudo = 0;
           NewEscudo = DamageBullet - escudo;
           RestarVida(NewEscudo);
           escudo = 0;
           NewEscudo = 0;    
     }
    else if (DamageBullet <= escudo)
{ 
    RestarEscudo(DamageBullet);
}
 }
}

if (other.gameObject.tag == "Missile")
 {
if (escudo == 0)
{
RestarVida(DamageMissile);
 }
     if ((DamageMissile > escudo && escudo > 0))  
     {
           float NewEscudo = 0;
           NewEscudo = DamageMissile - escudo;
           RestarVida(NewEscudo);
           escudo = 0;
           NewEscudo = 0;      
     }
    else if (DamageMissile <= escudo)
{ 
    RestarEscudo(DamageMissile);
}
}


if (other.gameObject.tag == "Island")
 {
if (escudo == 0)
{
RestarVida(DamageIsland);
 }
     if ((DamageIsland > escudo && escudo > 0))     
     {
           float NewEscudo = 0;
           NewEscudo = DamageIsland - escudo;
           RestarVida(NewEscudo);
           escudo = 0;
           NewEscudo = 0;
     }
    else if (DamageIsland <= escudo)
{ 
    RestarEscudo(DamageIsland);
}
 }




/////

if (this.gameObject.tag == "Player2")
{
if ((other.gameObject.tag == "BulletPlayer1") || (other.gameObject.tag == "BulletPlayer3") || (other.gameObject.tag == "BulletPlayer4") || (other.gameObject.tag == "EnemyBullet"))
{
if (escudo == 0) {
RestarVida(DamageBullet);
 }
     if ((DamageBullet > escudo && escudo > 0)) 
     {
           float NewEscudo = 0;
           NewEscudo = DamageBullet - escudo;
           RestarVida(NewEscudo);
           escudo = 0;
           NewEscudo = 0;    
     }
    else if (DamageBullet <= escudo)
{ 
    RestarEscudo(DamageBullet);
}
 }
}


/////

if (this.gameObject.tag == "Player3")
{
if ((other.gameObject.tag == "BulletPlayer1") || (other.gameObject.tag == "BulletPlayer2") || (other.gameObject.tag == "BulletPlayer4") || (other.gameObject.tag == "EnemyBullet"))
{
if (escudo == 0) {
RestarVida(DamageBullet);
 }
     if ((DamageBullet > escudo && escudo > 0)) 
     {
           float NewEscudo = 0;
           NewEscudo = DamageBullet - escudo;
           RestarVida(NewEscudo);
           escudo = 0;
           NewEscudo = 0;    
     }
    else if (DamageBullet <= escudo)
{ 
    RestarEscudo(DamageBullet);
}
 }
}

/////

if (this.gameObject.tag == "Player4")
{
if ((other.gameObject.tag == "BulletPlayer1") || (other.gameObject.tag == "BulletPlayer2") || (other.gameObject.tag == "BulletPlayer3") || (other.gameObject.tag == "EnemyBullet"))
{
if (escudo == 0) {
RestarVida(DamageBullet);
 }
     if ((DamageBullet > escudo && escudo > 0)) 
     {
           float NewEscudo = 0;
           NewEscudo = DamageBullet - escudo;
           RestarVida(NewEscudo);
           escudo = 0;
           NewEscudo = 0;    
     }
    else if (DamageBullet <= escudo)
{ 
    RestarEscudo(DamageBullet);
}
 }
}



 /////

}

//------------------------------------------------------------------

}}



    

                            

