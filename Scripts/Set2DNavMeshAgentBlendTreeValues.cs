using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Set2DBlendTreeValues : MonoBehaviour
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
        _animator.SetFloat("SpeedX", _navMeshAgent.velocity.magnitude);
        _animator.SetFloat("SpeedZ", _navMeshAgent.velocity.magnitude);

    }
}
