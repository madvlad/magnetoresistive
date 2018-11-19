using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour {
    public AudioSource reportSoundSource;
    public AudioClip reportSound;
    public Animation gunAnimation;
    public GameObject flash;
    public GameObject bulletHole;
    public GameObject crosshair;
    public float reloadTime = 2f;

    private float reloadChange = 0.0f;

    public void FixedUpdate()
    {
        if (reloadChange > 0.0f)
        {
            reloadChange -= Time.deltaTime;
        }
    }

    public void Update()
    {
        if (Input.GetButtonDown("Fire1") && this.reloadChange <= 0.0f)
        {
            this.reloadChange = this.reloadTime;
            this.reportSoundSource.PlayOneShot(reportSound);
            this.gunAnimation.Play();
            this.flash.SetActive(true);
            Invoke("HideFlash", 0.05f);

            RaycastHit hit;
            int layerMask = ~(1 << 2);
            
            if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, Mathf.Infinity, layerMask))
            {
                if (hit.collider.CompareTag("Enemy"))
                {
                    hit.collider.gameObject.SendMessage("ReceiveHit");
                }
                else
                {
                    var hitRotation = Quaternion.FromToRotation(Vector3.right, hit.normal);
                    Vector3 hitPoint = new Vector3(hit.point.x, hit.point.y, hit.point.z) + (hit.normal * 0.1f);
                    GameObject.Instantiate(bulletHole, hitPoint, hitRotation);
                }
            }
        }

        if (Input.GetButton("Fire2"))
        {
            crosshair.SetActive(true);
        }
        else
        {
            crosshair.SetActive(false);
        }
    }

    void HideFlash()
    {
        this.flash.SetActive(false);
    }
}
