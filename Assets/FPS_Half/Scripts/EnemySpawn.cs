﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour {

    public GameObject enemy;
	
	void Spawn()
    {
        Instantiate(enemy, gameObject.transform);
    }
}
