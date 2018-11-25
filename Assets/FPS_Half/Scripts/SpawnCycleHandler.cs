using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCycleHandler : MonoBehaviour {

    public int waves = 3;
    public List<int> wavetotal;
    private int idx = 0;

    private void Start() {
        SpawnWave();
    }

    void Update() {

    }

    void SpawnWave() {
        GameObject.FindGameObjectsWithTag("Manager")[0].GetComponent<SpawnHandler>().SendMessage("SpawnWave");
    }

    void NextWave() {
        idx++;
        SpawnWave();
    }


}
