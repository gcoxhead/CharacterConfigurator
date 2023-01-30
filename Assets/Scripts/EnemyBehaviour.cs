using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyBehaviour : MonoBehaviour
{
    public Transform Player;
    public Transform PatrolRoute;
    public List<Transform> Locations;
    private int _locationIndex = 0;
    private NavMeshAgent _agent;
    private int _lives = 3;
    public ParticleSystem EnemyExplode;
    public GameObject powerUp;
    public int EnemyLives
    {
        get { return _lives; }
        
        private set
        {
            _lives = value;
            if (_lives <=0)
            { Destroy(this.gameObject);
                Instantiate(EnemyExplode, gameObject.transform.position, Quaternion.identity);
                Instantiate(powerUp, gameObject.transform.position, Quaternion.identity);
                Debug.Log("Enemy Down!");
            }
        }
    }

    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        Player = GameObject.Find("Player").transform;
        //EnemyExplode = GameObject.Find("EnemyExplode");
        //Instantiate(EnemyExplode, gameObject.transform.position, Quaternion.identity);
        InitializePatrolRoute();

        MoveToNextPatrolLocation();

    }
    void Update()
    {
        if(_agent.remainingDistance <0.2f && !_agent.pathPending)
        {
            MoveToNextPatrolLocation();
        }
    }
    void InitializePatrolRoute()
    {
        foreach (Transform child in PatrolRoute)
        {
            Locations.Add(child);
        }
    }
    
    void MoveToNextPatrolLocation()
    {
        if (Locations.Count == 0)
            return;

        _agent.destination = Locations[_locationIndex].position;

        _locationIndex = (_locationIndex +1) % Locations.Count;

    }
      
    //isTrigger must be ticked in the inspector to allow player to enter the collider zone.
    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            _agent.destination = Player.position;
            Debug.Log("Player detected - attack!");
        }

        if (other.gameObject.CompareTag ("Bullet"))
        {
            EnemyLives -= 1;
            Debug.Log("Critical hit!");
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.name == "Player")
        {
            Debug.Log("Player out of range, resume patrol");
        }
    }
    
}
    
