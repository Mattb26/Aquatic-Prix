using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterController))]
public class SimpleMove : MonoBehaviour
{
       public float velocidadNormal;           // mi velocidad normal
        [HideInInspector] 
        public float BoostTimer; // its a timer to know how long its been activated
        [HideInInspector] 
       public float DuracionSpeedPowerUp;
   
        [HideInInspector] 
        public bool boosting; //is it boosting or not?

       public float rotacionVelocidad = 3.0F;
       [HideInInspector] 
       public float IncrementoVelocidad;
       [HideInInspector] 
       public float velocidadNormal2;
    
      
   
void Start() {
    
    velocidadNormal2 = velocidadNormal;
    BoostTimer = 0; 
    boosting = false;   
    
}
    void FixedUpdate()
    {
        
        CharacterController controller = GetComponent<CharacterController>();

        // Rotate around y - axis
        transform.Rotate(0, Input.GetAxis("Horizontal") * rotacionVelocidad, 0);

        // Move forward / backward
        Vector3 haciaAdelante = transform.TransformDirection(Vector3.forward);
        float actualVelocidad = velocidadNormal * Input.GetAxis("Vertical");
        controller.SimpleMove(haciaAdelante * actualVelocidad);

        if (boosting)
        {  
           
           BoostTimer += Time.deltaTime;
          

           if(BoostTimer >= DuracionSpeedPowerUp)
           {
             velocidadNormal = velocidadNormal / IncrementoVelocidad;
             BoostTimer = 0;
             boosting = false;
           }
        }
    }

 //public void OnTriggerEnter(Collider other) 
//{
//if (other.tag == "SpeedPowerUp")
//{   
 //   velocidadNormal = velocidadNormal2;
 //   velocidadNormal = velocidadNormal * IncrementoVelocidad;
 //   boosting = true;
 //   
 //   Destroy(other.gameObject);
            
            

//}
}
//}
//

