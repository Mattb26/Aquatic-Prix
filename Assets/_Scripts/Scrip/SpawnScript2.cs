using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript2 : MonoBehaviour
{
    public GameObject[] spawnObjects;
    public Transform[] spawnLocations;
    public bool timerStarted = true;
    public float timer_ = 0;
    public float TimeIWantInSeconds = 5f;



    // Start is called before the first frame update
    void Start()
    {

        Spawn();

    }

    // Update is called once per frame
    void Update()
    {


        if (timerStarted == true)
        {
            timer_ = timer_ + Time.deltaTime;
        }

        if (timer_ >= TimeIWantInSeconds)
        {
            timer_ = 0;
            Spawn();
            timerStarted = false;
            timerStarted = true;
            // timerStarted = false;
        }
    }



    void Spawn()
    {
       

   //     if ((GameObject.FindGameObjectsWithTag("SpeedPowerUp").Length < 2) && (GameObject.FindGameObjectsWithTag("HealthPowerUp").Length < 2))
   //     {
    //        for (int i = 0; i < spawnLocations.Length; i++)
    //        {

      //          Instantiate(spawnObjects[Random.Range(0, spawnObjects.Length)], spawnLocations[i]);

      //      }

      //  }




    }


}

    








