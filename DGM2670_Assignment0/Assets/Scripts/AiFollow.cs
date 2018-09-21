using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

/* I think if I add more to this, I could make it into
 something for the Asset Store. I created one of my AI
 like this in my game for 1600 and I really liked how
 versatile it could be. I think others may like it too.*/

[RequireComponent(typeof(NavMeshAgent))]
public class AiFollow : MonoBehaviour
{
    private NavMeshAgent agent;
    public Transform Player;

    public string Who;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
//        FollowDetermine();
    }

    private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.name == "Player")
            {
                Who = "Player";
                FollowDetermine();
            }

            if (other.gameObject.name == "Player" && other.gameObject.CompareTag("Coin"))
            {
                Who = "Player";
                FollowDetermine();
            }

            if (other.gameObject.name != "Player")
            {
                Who = "Noone";
                FollowDetermine();
            }

        }

    private void FollowDetermine()
    {
        switch (Who)
        {
            case "Player":
                transform.LookAt(Player.position);
                agent.destination = Player.position;

                break;
            
            case "Noone":
                agent.destination = transform.position;

                break;
        }
    }
 }

    
    
