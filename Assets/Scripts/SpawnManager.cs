using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;

    private float spawnRange = 9f;
    
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(enemyPrefab, RandomSpawnPosition(), Quaternion.identity);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private Vector3 RandomSpawnPosition()
    {
        float randX = Random.Range(-spawnRange, spawnRange);
        float randZ = Random.Range(-spawnRange, spawnRange);
        return new Vector3(randX, 0, randZ);
    }
}
