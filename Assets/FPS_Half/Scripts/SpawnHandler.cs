using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHandler : MonoBehaviour {
    public List<GameObject> spawners;
    public float spawnCooldown = 30.0f;
    public bool isWaveSpawn = false;

    private float spawnCounter;
    private int enemiesSpawned = 0;
    private int enemiesDestroyed = 0;

    private void Start()
    {
        spawnCounter = spawnCooldown;
    }

    void Update () {
        if (!isWaveSpawn)
        {
            if (spawnCounter < 0.0f)
            {
                int idx = Random.Range(0, spawners.Count);
                spawners[idx].SendMessage("Spawn");
                spawnCounter = spawnCooldown;
            }
            else
            {
                spawnCounter -= Time.deltaTime;
            }
        }
	}

    void SpawnWave(int numToSpawn) {
        Debug.Log("Spawning enemy");
        enemiesSpawned = numToSpawn;
        for (int i = 0; i < numToSpawn; i++) {
            spawners[i].SendMessage("Spawn");
        }
    }

    void EnemyDestroyed() {
        enemiesDestroyed++;

        if (enemiesDestroyed == enemiesSpawned) {
            GameObject.FindGameObjectsWithTag("Manager")[0].GetComponent<SpawnCycleHandler>().SendMessage("NextWave");
        }
    }
}
