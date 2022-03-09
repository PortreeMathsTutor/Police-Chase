using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SetBlendTreeFloat : MonoBehaviour
{
    private NavMeshAgent _navMeshAgent;
    private Animator _animator;
    private void Awake()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
        _animator = GetComponent<Animator>();
    }


    void Update()
    {
        _animator.SetFloat("Speed", _navMeshAgent.velocity.magnitude);

    }
}
