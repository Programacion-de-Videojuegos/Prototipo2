using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{

    float velocidad = 20;
    void Start()
    {
        
    }

    void Update()
    {
        if (transform.position.z > 20) {
            Destroy(gameObject);
        } 
        else if (transform.position.z < -10)
        {
            Destroy(gameObject);
        }

        
        transform.Translate(Vector3.forward*Time.deltaTime*velocidad);
    }
}
