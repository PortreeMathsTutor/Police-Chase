using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{
    // The target marker.
    private GameObject _player;
    private int _timer;
    private void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        _timer += 1;
        if (_timer%150==0)
        {  // Rotate the camera every frame so it keeps looking at the target
            transform.LookAt(_player.transform.position);
        }
      
    }
}
