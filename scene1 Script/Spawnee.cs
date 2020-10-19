using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnee : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float randomPos =transform.position.x+ Random.Range(-3f, 3f);
        transform.position = new Vector3(randomPos, transform.position.y, transform.position.z + Random.Range(-1f, 1f));
    }

   
}
