using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] arrayGO;
    [SerializeField] float spawnTime = 1.0f;


    void Start()
    {
        InvokeRepeating("RandomSpawner", spawnTime, spawnTime);
    }

    void Update()
    {
        
    }

    void RandomSpawner()
    {
        int j = Random.Range(0, arrayGO.Length);
        Instantiate(arrayGO[j], transform.position, Quaternion.identity);
    }
}
