using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner2 : MonoBehaviour
{
    [SerializeField] GameObject spawnee;
    [SerializeField] Transform pos1;
    [SerializeField] Transform pos2;
    [SerializeField] Transform pos3;
    // Start is called before the first frame update
    public float spawnRate;
    void Start()
    {
        InvokeRepeating("SpawnFunc", 0, spawnRate);
    }
    void SpawnFunc()
    {
        Instantiate(spawnee, pos1);
        Instantiate(spawnee, pos2);
        Instantiate(spawnee, pos3);
    }
    // Update is called once per frame
   
}
