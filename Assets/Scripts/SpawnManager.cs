using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animales;

    void Start()
    {
        InvokeRepeating("SpawnAnimales", 2.0F, 0.8F);
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            SpawnAnimales();
        }
    }

        void SpawnAnimales()
        {

            int indice = Random.Range(0, animales.Length);
            int rango = Random.Range(-20, 20);
            Vector3 pos = new Vector3(rango, 0, 20);
            Instantiate(animales[indice], pos, animales[indice].transform.rotation);
        }

    
}
