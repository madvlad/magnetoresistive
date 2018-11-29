using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Level1Objectives : MonoBehaviour {
    public int KillCount = 0;
    public int Target;
    public Text numberLeftText;
    public GameObject ErrorText;
    public GameObject GoodText;

	void Progress()
    {
        KillCount++;

        if (KillCount >= Target)
        {
            numberLeftText.text = "0";
            Win();
        }
        else
        {
            numberLeftText.text = (Target - KillCount).ToString();
        }
    }

    void Win()
    {
        ErrorText.SetActive(false);
        GoodText.SetActive(true);
        Invoke("LoadScene", 5.0f);
    }

    void LoadScene()
    {
        SceneManager.LoadScene("Cutscene2");
    }
}
