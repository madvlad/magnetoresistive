using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Level3Objectives : MonoBehaviour {
    public float timeToBeat = 120.0f;
    public Text timeLeftText;

    private float timeLeft = 120.0f;

    void Start()
    {
        timeLeft = timeToBeat;
    }

    // Update is called once per frame
    void Update () {
        timeLeft -= Time.deltaTime;
        if (timeLeft <= 0)
        {
            this.timeLeftText.text = "0";
            SceneManager.LoadScene("Cutscene4");
        } else
        {
            this.timeLeftText.text = Mathf.FloorToInt(timeLeft) + "s";
        }
	}
}
