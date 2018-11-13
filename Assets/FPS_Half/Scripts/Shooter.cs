using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour {
    public AudioSource reportSoundSource;
    public AudioClip reportSound;
    public Animation gunAnimation;
    public GameObject flash;
    public GameObject bulletHole;

    private float reloadTime = 2f;
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
            
            if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, Mathf.Infinity))
            {
                var hitRotation = Quaternion.FromToRotation(Vector3.right, hit.normal);
                Vector3 hitPoint = new Vector3(hit.point.x, hit.point.y, hit.point.z) + (hit.normal * 0.1f);
                GameObject.Instantiate(bulletHole, hitPoint, hitRotation);
            }
        }
    }

    void HideFlash()
    {
        this.flash.SetActive(false);
    }
}
