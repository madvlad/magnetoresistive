using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class PlayerBehavior : MonoBehaviour {

    public AudioClip playerDeathSound;
    public GameObject DeathOverlay;

	void Die()
    {
        gameObject.GetComponent<AudioSource>().PlayOneShot(playerDeathSound);
        gameObject.GetComponent<FirstPersonController>().enabled = false;
        gameObject.GetComponent<Shooter>().enabled = false;
        gameObject.GetComponent<CharacterController>().enabled = false;
        DeathOverlay.SetActive(true);
        Invoke("ReloadScene", 5.0f);
    }

    void ReloadScene()
    {
        var currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.name);
    }
}
