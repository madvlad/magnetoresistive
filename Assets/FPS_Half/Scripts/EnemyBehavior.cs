using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour {

    public AudioClip painSound;
    public AudioClip deathSound;
    public GameObject painMesh;
    public int Health;

    private GameObject playerGameObject;
    private GameObject managerGameObject;

    void Start()
    {
        playerGameObject = GameObject.FindGameObjectWithTag("Player");
        managerGameObject = GameObject.FindGameObjectWithTag("Manager");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.SendMessage("Die");
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

    void FixedUpdate()
    {
        Vector3 parentObjectPosition = gameObject.transform.position;
        RaycastHit hit;
        Vector3 direction = playerGameObject.transform.position - parentObjectPosition;

        Ray ray = new Ray(parentObjectPosition, direction);

        if (Physics.Raycast(ray, out hit, float.MaxValue))
        {
            if (hit.collider.CompareTag("Player"))
            {
                float step = Time.deltaTime * 1.4f;
                gameObject.transform.parent.transform.Translate(direction * step);
            }
        }
    }

    void Kill()
    {
        gameObject.GetComponent<BoxCollider>().enabled = false;
        gameObject.GetComponent<MeshRenderer>().enabled = false;
        gameObject.GetComponent<AudioSource>().Stop();
        gameObject.GetComponent<AudioSource>().PlayOneShot(deathSound, 15.0F);
        if (managerGameObject != null)
        {
            managerGameObject.SendMessage("Progress");
        }
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
