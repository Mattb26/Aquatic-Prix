using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps : MonoBehaviour
{
    

    public GameObject Camera11;
    public GameObject Camera22;
    public GameObject Camera33;
    public GameObject Camera44;
    public GameObject ChooseAShip;
    

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
private cambiarmateriales camb;
private devolvermateriales devo;
//-------------------------------------------------------------------------------------------//
//- PowerUpForceShield
public float DuracionForceShield;
private CrearForceField forcefild;
//-------------------------------------------------------------------------------------------//



 void Awake()
{
lifee_And_Damage = ChooseAShip.GetComponent<Life_And_Damage>(); //lifee_And_Damage (a variable) = ChooseAShip(Own Ship).GetComponent(from that gameobject)called<Life_And_Damage>();
simpleeMovee = ChooseAShip.GetComponent<SimpleMove>();
camb = ChooseAShip.GetComponent<cambiarmateriales>();
devo = ChooseAShip.GetComponent<devolvermateriales>();
forcefild = ChooseAShip.GetComponent<CrearForceField>();
 





if (this.gameObject.tag == "Player")
{
    Camera11.SetActive(true);
}  
if (this.gameObject.tag == "Player2")
{
    Camera22.SetActive(true);
} 

if (this.gameObject.tag == "Player3")
{
    Camera33.SetActive(true);
} 

if (this.gameObject.tag == "Player4")
{
    Camera44.SetActive(true);
} 


}

  void Update() {
      
    
}

void Start()
    {   


    }

void OnTriggerEnter(Collider other)
{
if (other.tag == "HealthPowerUp")
{      
        FindObjectOfType<AudioManager>().Play("Powerup");
        Destroy(other.gameObject);
        lifee_And_Damage.vida = lifee_And_Damage.vida + CantidadCuracion;
        

        if (lifee_And_Damage.vida > lifee_And_Damage.vidaMaxima)
        {
            lifee_And_Damage.vida = lifee_And_Damage.vidaMaxima;
        }

}

if (other.tag == "ShieldPowerUp")
{
        FindObjectOfType<AudioManager>().Play("Powerup");
        Destroy(other.gameObject);
        lifee_And_Damage.escudo = lifee_And_Damage.escudo + CantidadEscudo;
        

        if (lifee_And_Damage.escudo > lifee_And_Damage.escudoMaximo)
        {
          lifee_And_Damage.escudo = lifee_And_Damage.escudoMaximo;
        }

}

if (other.tag == "SpeedPowerUp")
{   
    
    simpleeMovee.BoostTimer = 0;
    simpleeMovee.DuracionSpeedPowerUp = DuracionVelocidad;
    simpleeMovee.IncrementoVelocidad = IncrementoVelocidad;
    simpleeMovee.velocidadNormal = simpleeMovee.velocidadNormal2;
    simpleeMovee.velocidadNormal = simpleeMovee.velocidadNormal * IncrementoVelocidad;
    
    simpleeMovee.boosting = true;
    FindObjectOfType<AudioManager>().Play("Powerup");
    Destroy(other.gameObject);

}

if (other.tag == "InvisiblePowerUp")
{
        FindObjectOfType<AudioManager>().Play("Powerup");
        Destroy(other.gameObject);

                devo.tiempoDuracion = DuracionInvisible;
       camb.cambiar();
       devo.dothething();


    //    invii.duracionInvisibilidad = invii.duracionInvisibilidad + DuracionInvisible;
    //    invii.Start();
        //gameObject.layer = 0;

}

if (other.tag == "ForceFieldPowerUp")
{       
        FindObjectOfType<AudioManager>().Play("Powerup");
        Destroy(other.gameObject);
        forcefild.starty2();

        


        
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
