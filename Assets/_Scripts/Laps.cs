using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laps : MonoBehaviour
{
    // These Static Variables are accessed in "checkpoint" Script
    public Transform[] checkPointArray;
    public static Transform[] checkpointA;
    public static int currentCheckpoint = 0;
    public static int currentLap = 0;
    public Vector3 startPos;
    public int Lap;
    public GameObject menuUI;

    void Start()
    {
        startPos = transform.position;
        currentCheckpoint = 0;
        currentLap = 0;

    }

    void Update()
    {
        Lap = currentLap;
        checkpointA = checkPointArray;
        victoria();
    }

    void victoria()
    {
        if (Lap >= 3)
        {
            menuUI.SetActive(true);
            Time.timeScale = 0f;
        }

    }
}
