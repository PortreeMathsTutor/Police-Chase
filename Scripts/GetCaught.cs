using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetCaught : MonoBehaviour
{
    public GameObject prefabToSpawn;
    public static int score;
    private void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {

                Instantiate(prefabToSpawn, transform.position, Quaternion.identity);
                Destroy(gameObject);
   
            score += 1;
         
        }
      
    }
}
