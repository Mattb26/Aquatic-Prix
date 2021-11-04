using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps : MonoBehaviour
{
public GameObject ChooseAShip;
public GameObject ChooseAForceShield;
//-------------------------------------------------------------------------------------------//
// - PowerUpVida y PowerUpEscudos
public float CantidadCuracion;
public float CantidadEscudo;
private Life_And_Damage lifee_And_Damage;
//-------------------------------------------------------------------------------------------//
//- PowerUpVelocidad
public float DuracionVelocidad; //>velocidad
public float IncrementoVelocidad; //>rotacionvelocidad
private SimpleMove simpleeMovee; //Make a timer for 18 seconds or so
//-------------------------------------------------------------------------------------------//
//- PowerUpInvisible
public float DuracionInvisible;
private BetterInvi invii;
//-------------------------------------------------------------------------------------------//
//- PowerUpForceShield
public float DuracionForceShield;
private ForceField forcefild;
//-------------------------------------------------------------------------------------------//

 void Awake()
{
lifee_And_Damage = ChooseAShip.GetComponent<Life_And_Damage>(); //lifee_And_Damage (a variable) = ChooseAShip(Own Ship).GetComponent(from that gameobject)called<Life_And_Damage>();
simpleeMovee = ChooseAShip.GetComponent<SimpleMove>();
invii = ChooseAShip.GetComponent<BetterInvi>();
forcefild = ChooseAForceShield.GetComponent<ForceField>();

}

void Start()
    {   

    }

void OnTriggerEnter(Collider other)
{
if (other.tag == "HealthPowerUp")
{      
        Destroy(other.gameObject);
        lifee_And_Damage.vida = lifee_And_Damage.vida + CantidadCuracion;
        

        if (lifee_And_Damage.vida > lifee_And_Damage.vidaMaxima)
        {
            lifee_And_Damage.vida = lifee_And_Damage.vidaMaxima;
        }

}

if (other.tag == "ShieldPowerUp")
{
        Destroy(other.gameObject);
        lifee_And_Damage.escudo = lifee_And_Damage.escudo + CantidadEscudo;
        

        if (lifee_And_Damage.escudo > lifee_And_Damage.escudoMaximo)
        {
          lifee_And_Damage.escudo = lifee_And_Damage.escudoMaximo;
        }

}

if (other.tag == "SpeedPowerUp")
{
        Destroy(other.gameObject);
        simpleeMovee.velocidad = simpleeMovee.velocidad * IncrementoVelocidad;  //4
        simpleeMovee.duracion = simpleeMovee.duracion + DuracionVelocidad;     //6
        //simpleeMovee.timepo();
        if (simpleeMovee.duracion > 0) {
        simpleeMovee.duracion -= Time.deltaTime;
        }
        else if(simpleeMovee.duracion == 0)
        {
            simpleeMovee.velocidad = simpleeMovee.velocidad / IncrementoVelocidad;
        }
        
}

if (other.tag == "InvisiblePowerUp")
{
        gameObject.layer = 1;
        Destroy(other.gameObject);
    //    invii.duracionInvisibilidad = invii.duracionInvisibilidad + DuracionInvisible;
    //    invii.Start();
        //gameObject.layer = 0;

}

if (other.tag == "ForceFieldPowerUp")
{       
        Destroy(other.gameObject);
        

        


        
      //  forcefild.duracionPowerUpForceShield = forcefild.duracionPowerUpForceShield + DuracionForceShield;
        
        

         }
   
     }

}


       
    
        
    







//PowerUpSpeed
//PowerUpHeal
//PowerUpForceField
//PowerUpInvisibility
//PowerUpInvincibility

//Store the powerups in a singleton or something. the max quantity will be 1. when you pick up one, the image will be 'enabled' 
//if another image is enabled you already have 1, Then it will not enable the image nor work.
//timer.... when timer reaches 
//its better to use Tags? Like, if tag PowerUpSpeed, it will have a variable of 1, it will 


// que se rompan las islas, pero solo una parte.
