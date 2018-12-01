using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCycleHandler : MonoBehaviour {

    public int waves = 3;
    public List<int> wavetotal;
    private int idx = 0;

    SpawnHandler spawnHandler;

    private void Start() {
        spawnHandler = GameObject.FindGameObjectsWithTag("Manager")[0].GetComponent<SpawnHandler>();
        SpawnWave();
    }

    void SpawnWave() {
        spawnHandler.SpawnWave(wavetotal[idx]);
    }

    public void NextWave() {
        idx++;

        if (idx > waves)
        {
            // YOU WIN
        }
        else
        {
            SpawnWave();
        }
    }


}
