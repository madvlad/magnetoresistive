using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlinkingLight : MonoBehaviour {

    public float blinkTime = 0.5f;
	// Use this for initialization
	void Start () {
        InvokeRepeating("Blink", 0, blinkTime);
    }

    void Blink() {
        gameObject.SetActive(!gameObject.active);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
