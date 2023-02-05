using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIPlayerDetect : MonoBehaviour
{
    // Start is called before the first frame update
    public NavMeshAgent _agent;
    public Transform Player;
    void Start()
    {
        //_agent = GetComponent<NavMeshAgent>();
    }

    private void OnTriggerStay(Collider other)
    {
            if (other.name == "Player" )
            {
            attack();
            }
    }

    private void Update()
    {
        // set _agent position

    }

    private void attack()
    {
        // set _agent position
        {
            if (_agent == null)
                Destroy(gameObject);
            
            else
            _agent.destination = Player.position;
            Debug.Log("Player detected - attack!");
        }

    }

}
