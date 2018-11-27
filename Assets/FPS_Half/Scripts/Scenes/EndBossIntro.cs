using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndBossIntro : MonoBehaviour {
    public GameObject light1;
    public GameObject light2;
    public GameObject light3;
    public GameObject light4;
    public GameObject light5;

    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    public GameObject enemy4;
    public GameObject enemySpawners;

    public GameObject floor;
    public GameObject innerWalls;

    // Use this for initialization
    void Start () {
        Invoke("Step1", 11.0f);
        Invoke("Step2", 16.0f);
        Invoke("Step3", 22.0f);
        Invoke("Step4", 26.0f);
        Invoke("Step5", 34.0f);
        Invoke("Step6", 38.0f);
        Invoke("Step7", 43.0f);
        Invoke("Step8", 49.0f);
        Invoke("Step9", 54.0f);
        Invoke("Step10", 60.0f);
        Invoke("Step11", 106.0f);
        Invoke("Step12", 134.0f);
    }

    void Step1() { light1.SetActive(true); }
    void Step2() { light2.SetActive(true); }
    void Step3() { light3.SetActive(true); }
    void Step4() { light4.SetActive(true); }
    void Step5() { light5.SetActive(true); }
    void Step6() { enemy1.SetActive(true); }
    void Step7() { enemy2.SetActive(true); }
    void Step8() { enemy3.SetActive(true); }
    void Step9() { enemy4.SetActive(true); }
    void Step10() { floor.SetActive(false); }
    void Step11() { innerWalls.SetActive(false); }
    void Step12() { enemySpawners.SetActive(true);  }

    // Update is called once per frame
    void Update () {
		
	}
}
