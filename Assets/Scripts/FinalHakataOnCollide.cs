using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class FinalHakataOnCollide : MonoBehaviour {

    private AudioSource audioSource;
    public AudioClip sound;

    public Transform rollingHakataPrefab;

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
        if (SceneManager.GetSceneByName("Congratulation").isLoaded == false)
        {
            if (col.gameObject.CompareTag("FinalHakata"))
                UnityEngine.SceneManagement.SceneManager.LoadScene("Congratulation", UnityEngine.SceneManagement.LoadSceneMode.Additive);
        }
        else
        {
            if (!col.gameObject.CompareTag("Hakata"))
            {
                audioSource.Play();
                Instantiate(rollingHakataPrefab, transform.position, Quaternion.identity);
            }
        }
    }
}
