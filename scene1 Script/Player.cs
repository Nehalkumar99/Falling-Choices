using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float speed;

    
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal") * Time.deltaTime*speed;
        float vertical = Input.GetAxis("Vertical") * Time.deltaTime*speed;
        transform.Translate(horizontal, 0, vertical);
        transform.localScale += new Vector3(0.1f, 0.1f, 0.1f) * Time.deltaTime;
    }
}
