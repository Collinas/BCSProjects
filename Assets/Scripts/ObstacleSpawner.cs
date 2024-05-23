using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] public GameObject obstaclePrefab;
    [SerializeField] float spawnInterval = 2f; /* seconds between spawning obstacles */
    [SerializeField] float maxX = 10f;
    [SerializeField] float minX = -10f;
    [SerializeField] float maxY = 8f;
    [SerializeField] float minY = -8f;

    void Start()
    {
        InvokeRepeating("SpawnObstacles", spawnInterval, spawnInterval);
    }

    void Update()
    {
        //SpawnObstacles(); 
    }

    void SpawnObstacles()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);
        Vector2 randomPosition = new Vector2(randomX, randomY);
        Instantiate(obstaclePrefab, randomPosition, Quaternion.identity);
    }
}
