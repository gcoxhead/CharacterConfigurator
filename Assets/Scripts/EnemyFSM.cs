using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFSM : MonoBehaviour
{
    public enum EnemyState {  GoToBase, AttackBase, ChasePlayer, AttackPlayer}

    public EnemyState currentState;
    private void Update()
    {
        if (currentState == EnemyState.GoToBase)
            GoToBase();
        else if (currentState == EnemyState.AttackBase)
            AttackBase();
        else if (currentState == EnemyState.ChasePlayer)
            ChasePlayer();
        else if (currentState == EnemyState.AttackPlayer)
            AttackPlayer();
    }

    public Sight sightSensor;
    void GoToBase()
    {
        if (sightSensor.detectedObject != null)
        {
            currentState = EnemyState.ChasePlayer;
        }
        Debug.Log("Go To Base");
    } 
    
    void AttackBase()
    {
        Debug.Log("Attack Base!");
    }

    void ChasePlayer()
    {
        Debug.Log("Chase Player!");
    }

        void AttackPlayer()
    {
        Debug.Log("Attack Player!");
    }


}
