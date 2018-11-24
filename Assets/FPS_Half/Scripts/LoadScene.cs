using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour {
    public string sceneName;
    public GameObject aboutWindow;

    public void LoadTheScene()
    {
        SceneManager.LoadScene(sceneName);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void ShowAbout()
    {
        aboutWindow.SetActive(true);
    }

    public void HideAbout()
    {
        aboutWindow.SetActive(false);
    }
}
