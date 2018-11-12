using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour {
    public AudioSource reportSoundSource;
    public AudioClip reportSound;
    public Animation gunAnimation;

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
        }
    }
}
