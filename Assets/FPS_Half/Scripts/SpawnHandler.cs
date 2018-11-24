using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHandler : MonoBehaviour {
    public List<GameObject> spawners;
    public float spawnCooldown = 30.0f;

    private float spawnCounter;

    private void Start()
    {
        spawnCounter = spawnCooldown;
    }

    void Update () {
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
