using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject spawnee;
   
    private void Start()
    {
        InvokeRepeating("spawn", 2, 2);
    }
    void spawn()
    {

        Instantiate(spawnee, transform);
    }
  
}
