using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class IA_Enemiga : MonoBehaviour
{
    public GameObject Target;
    public NavMeshAgent agent;
    public float distance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        //if (Vector3.Distance(Target.transform.position, transform.position) < distance)
        if (Vector3.Distance(GameObject.FindGameObjectWithTag("Player").transform.position, transform.position) <= distance)
        {
            //agent.SetDestination(Target.transform.position);
            agent.SetDestination(GameObject.FindGameObjectWithTag("Player").transform.position);
        }
        else
        {
            agent.speed = 0;
        }
    }
}
