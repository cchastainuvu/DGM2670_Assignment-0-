using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

//BASELINE AI//

[RequireComponent(typeof(NavMeshAgent))]
public class AiAgent : MonoBehaviour
{

    private NavMeshAgent agent;
    public Transform Player;
    public bool CanChase;
    
    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        //When using GetComponent, be sure to use the same type as the assigned.
    }

    private void OnTriggerEnter(Collider other)
    {
        //Changes destination upon entering the object's trigger.

        CanChase = true;

    }

    private void Update()
    {
        if (CanChase)
        {
            agent.destination = Player.position;  
        }
        else
        {
            agent.destination = transform.position; 
        }
       
        

        //agent.destination = transform.position;
        //This will essentially have the agent following its own transformation. 

        //"Transform" is the class, "transform" is a static variable.
        //Transform is built in because it is required.

        //Hover over things in Rider for useful tips!


    }
    
    
}
