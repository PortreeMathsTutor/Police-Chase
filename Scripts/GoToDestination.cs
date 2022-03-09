using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class GoToDestination : MonoBehaviour
{
    private GameObject _destination;
    private NavMeshAgent _navMeshAgent;
    private int _timeer;
    // Start is called before the first frame update
    void Start()
    {
     
        _destination = GameObject.FindGameObjectWithTag("Destination");
        _navMeshAgent = GetComponent<NavMeshAgent>();
        _navMeshAgent.destination = _destination.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        _timeer += 1;
      
        if (_timeer % 200 == 0) { _navMeshAgent.destination = _destination.transform.position; }
    }
}
