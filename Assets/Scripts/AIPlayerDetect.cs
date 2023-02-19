using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIPlayerDetect : MonoBehaviour
{
    // Start is called before the first frame update
    public NavMeshAgent _agent;
    public Transform PlayerTransform;
    void Start()
    {
        //_agent = GetComponent<NavMeshAgent>();
        PlayerTransform = GameObject.Find("Player").transform;
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
            _agent.destination = PlayerTransform.position;
            Debug.Log("Player detected - attack!");
        }

    }

}
