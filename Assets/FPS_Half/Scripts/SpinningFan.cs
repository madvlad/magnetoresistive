using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningFan : MonoBehaviour {

    public float rotation = 1.0f;
    public bool xaxis = false;

	void Start () {
		
	}
	
	void Update () {
        Vector3 axis = new Vector3(0.0f, 1.0f, 0.0f);
        if (xaxis)
            axis = new Vector3(1.0f, 0.0f, 0.0f);
        Vector3 rot = axis * rotation * Time.deltaTime;
        transform.Rotate(rot);
    }
}
