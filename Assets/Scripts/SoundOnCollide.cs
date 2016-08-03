using UnityEngine;
using System.Collections;

public class SoundOnCollide : MonoBehaviour {

    private AudioSource audioSource;
    public AudioClip sound;

	// Use this for initialization
	void Start () {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = sound;
        audioSource.loop = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision col)
    {
        audioSource.Play();
    }
}
