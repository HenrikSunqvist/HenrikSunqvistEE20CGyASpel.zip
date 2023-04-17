using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour 
{

    [SerializeField] private float spawnRateMin = 0f;

    [SerializeField] private float spawnRateMax = 6f;

    [SerializeField] private GameObject[] enemyPrefabs;

    [SerializeField] private bool canSpawn = true;

    private void Start() 
    {
        StartCoroutine(Spawner());
    }

    private IEnumerator Spawner () 
    {
               
        while (canSpawn) {
            float spawnRand = Random.Range(spawnRateMin, spawnRateMax);
            yield return new WaitForSeconds(spawnRand);
            int rand = Random.Range(0, enemyPrefabs.Length);
            GameObject enemyToSpawn = enemyPrefabs[rand];

            Instantiate(enemyToSpawn, transform.position, Quaternion.identity);
        }
    }

}