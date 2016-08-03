using UnityEngine;
using System.Collections;

public class VisibleOnCollide : MonoBehaviour {

	public GameObject visibleObject;
    public string tag;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnCollisionEnter(Collision col)
	{
        if(tag=="" || col.gameObject.CompareTag(tag))
		    visibleObject.SetActive (true);
	}
}
