using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class GoToDestination : MonoBehaviour
{
   private GameObject _destination;
    private UnityEngine.AI.NavMeshAgent _navMeshAgent;
    private int _timeer;
    // Start is called before the first frame update
    void Start()
    {

        _destination = GameObject.FindGameObjectWithTag("Destination");
        _navMeshAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        _navMeshAgent.destination = _destination.transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        _timeer += 1;

        if (_timeer % 600 == 0) { _navMeshAgent.destination = _destination.transform.position; }
    }
}
