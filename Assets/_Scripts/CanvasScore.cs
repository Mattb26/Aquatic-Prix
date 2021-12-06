using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasScore : MonoBehaviour
{
public GameObject Score;

void Update()
{

if (Input.GetKeyDown(KeyCode.Tab))
{

if(Score.activeSelf == true)
    {
        Score.SetActive(false);
    }
    else
    {
        Score.SetActive(true);
    }

}

}
}