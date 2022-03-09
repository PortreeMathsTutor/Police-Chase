using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaner : MonoBehaviour
{private int numberOfPrefabs;
    public int numberToSpawn = 5;
    public GameObject prefabToSpawn;     
    public bool spawnOnStart = true;
    private float spawnFrequency;
    private float spawnTimer = 0.0f;

    // Use this for initialization
    void Start()
    {
        spawnFrequency = Random.Range(30f, 100f);
        if (spawnOnStart)
        {
            Spawn();
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Update the spawning timer
        spawnTimer += Time.deltaTime;

        // Spawn a prefab if the timer has reached spawnFrequency
        if (spawnTimer >= spawnFrequency)
        {
            // First reset the spawn timer to 0
            spawnTimer = 0.0f;
            if (numberOfPrefabs<=numberToSpawn) { Spawn(); }
       
        }


    }

    void Spawn()
    {
        // First check to see if the prefab hasn't been set
        if (prefabToSpawn != null)
        {
            numberOfPrefabs += 1;
            // Instantiate the prefab
            Instantiate(prefabToSpawn, transform.position, Quaternion.identity);
        }
    }
}

