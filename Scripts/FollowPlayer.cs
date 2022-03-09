using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowPlayer : MonoBehaviour
{
    private GameObject _player;
    private NavMeshAgent _navMeshAgent;
    private int _timeer;

    private void Awake()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
        _navMeshAgent = GetComponent<NavMeshAgent>();

    }


    void Update()
    {
        _timeer += 1;
        if (_timeer%20==0) { _navMeshAgent.destination = _player.transform.position; }
       
    }
}
