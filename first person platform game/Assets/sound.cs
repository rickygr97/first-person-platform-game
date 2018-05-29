using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour {
    private AudioSource soundmanager;


	// Use this for initialization
	void Start () {
        soundmanager = this.GetComponent<AudioSource>();
        soundmanager.playOnAwake = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (soundmanager.isPlaying && Input.GetKeyDown(KeyCode.Space))
        {
            soundmanager.Stop();

        }else if (!soundmanager.isPlaying && Input.GetKeyDown(KeyCode.Space))
            {
                soundmanager.Play();

            }

    }
}
