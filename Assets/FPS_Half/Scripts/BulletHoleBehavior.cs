using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletHoleBehavior : MonoBehaviour {
    public List<AudioClip> ricochetSounds;
	
	void Start () {
        int randomIdx = Random.Range(0, ricochetSounds.Count);
        gameObject.GetComponent<AudioSource>().PlayOneShot(ricochetSounds[randomIdx]);
        Invoke("KillSelf", 30.0f);
	}
	
    void KillSelf()
    {
        Destroy(gameObject);
    }
}
