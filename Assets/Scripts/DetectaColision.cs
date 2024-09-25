using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DetectaColision : MonoBehaviour
{
      void OnTriggerEnter(Collider food)
        {
            Destroy(gameObject);
            Destroy(food.gameObject);
        }
    
}
