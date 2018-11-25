using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningFan : MonoBehaviour {

    public float rotation = 1.0f;
	void Start () {
		
	}
	
	void Update () {
        transform.Rotate(0, rotation * Time.deltaTime, 0);
    }
}
