using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;


public class shipsMove : MonoBehaviour
{
   
    private CharacterController player;
    public float playerspeed = 25.0f;
    private float powerupboostTimer;
    private bool boosting;
    public float playerrotation = 200.0f;
    public float x, y;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<CharacterController>();
       
        powerupboostTimer = 0f;
        boosting = false;
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = -Input.GetAxis("Vertical");
        transform.Rotate(x * Time.deltaTime * playerrotation, 0, 0);
        transform.Translate(0, 0, y * Time.deltaTime * playerspeed);




        //if (boosting)
        //{
        //    powerupboostTimer += Time.deltaTime;
        //    if (powerupboostTimer >= 10)
        //    {
        //        playerspeed = 25;
        //        powerupboostTimer = 0;
        //        boosting = false;
        //    }
        //}
    }

    //void OnTriggerEnter(Collider other)
    //{
    //    if (other.tag == "SpeedPowerUp")
    //    {
            

    //            boosting = true;
    //            playerspeed = (playerspeed * 4);
    //            Destroy(other.gameObject);
            
    //    }

        
    //}
    


}


    // void OnTriggerEnter(Collider other)
//    {
    //if (other.tag == "SpeedPowerUp")
    //    boosting = true;
    //playerspeed = 100.0f;
   // Destroy(other.gameObject);
   //Este destruye todo basicamente, inclusive el disparo del jugador jaja
//   }






