using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour {

    public AudioClip painSound;
    public AudioClip deathSound;
    public GameObject painMesh;
    public int Health;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player hit!");
        }
    }

    public void ReceiveHit()
    {
        gameObject.GetComponent<AudioSource>().PlayOneShot(painSound, 5.0F);
        Health--;

        if (Health == 0)
        {
            Kill();
        }
        else
        {
            painMesh.GetComponent<MeshRenderer>().enabled = true;
            Invoke("HidePain", 1f);
        }
    }

    void Kill()
    {
        gameObject.GetComponent<BoxCollider>().enabled = false;
        gameObject.GetComponent<MeshRenderer>().enabled = false;
        gameObject.GetComponent<AudioSource>().Stop();
        gameObject.GetComponent<AudioSource>().PlayOneShot(deathSound, 15.0F);
        Invoke("DestroySelf", 10.0f);
    }

    void DestroySelf()
    {
        Destroy(gameObject);
    }

    void HidePain()
    {
        painMesh.GetComponent<MeshRenderer>().enabled = false;
    }
}
