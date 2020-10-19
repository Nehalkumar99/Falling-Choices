using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider : MonoBehaviour
{
   
    private void OnTriggerEnter(UnityEngine.Collider other)
    {
        Destroy(other.gameObject);
        //FindObjectOfType<BallSelector>().ballNumber = 0;
    }

    
}
