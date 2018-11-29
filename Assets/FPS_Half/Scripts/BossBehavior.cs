using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossBehavior : MonoBehaviour {
    public int Health = 10;

    public AudioClip painSound;
    public AudioClip deathSound;

    void ReceiveHit()
    {
        gameObject.GetComponent<AudioSource>().PlayOneShot(painSound, 2F);
        Health--;

        if (Health == 0)
        {
            Kill();
        }
    }

    void Kill()
    {
        gameObject.GetComponent<CapsuleCollider>().enabled = false;
        gameObject.GetComponent<SkinnedMeshRenderer>().enabled = false;
        gameObject.GetComponent<AudioSource>().PlayOneShot(deathSound, .5F);
        Invoke("EndGame", 10.0f);
    }

    void EndGame()
    {
        SceneManager.LoadScene("Cutscene5");
    }
}
