using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2Objectives : MonoBehaviour {

    // Use this for initialization
    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("Level3");
    }
}
