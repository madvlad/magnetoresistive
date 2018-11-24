using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathCatcher : MonoBehaviour {
    private GameObject playerObject;
    private bool Killed = false;

    void Start()
    {
        playerObject = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update () {
		if (playerObject.transform.position.y < -100 && !Killed)
        {
            playerObject.SendMessage("Die");
            Killed = true;
        }
	}
}
