using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class AIFollow : MonoBehaviour
{

    private NavMeshAgent agent;
    public string FollowTarget;
    public Transform Player;
    public Transform Coin;
    public Transform target;
    
    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            FollowTarget = "Player";
            FollowDetermine();
        }

        if (other.gameObject.name == "Coin")
        {
            FollowTarget = "Coin";
            FollowDetermine();
        }

        if (other.gameObject.name == "Player" && other.gameObject.name == "Coin")
        {
            FollowTarget = "Both";
            FollowDetermine();
        }

        if (other.gameObject.name != "Player" && other.gameObject.name != "Coin")
        {
            FollowTarget = "None";
            FollowDetermine();
        }
    }

    private void FollowDetermine()
    {
        switch (FollowTarget)
        {
            case "Player":
                agent.destination = Player.position;

             break;
            
            case "Coin":
                agent.destination = Coin.position;

             break;
            
            case "Both":
                agent.destination = Player.position;

             break;
            
            case "None":
                agent.destination = transform.position;
                
             break;
        }
    }
}
