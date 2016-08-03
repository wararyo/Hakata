using UnityEngine;
using System.Collections;

public class VisibleOnCollide : MonoBehaviour {

	public GameObject visibleObject;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnCollisionEnter(Collision col)
	{
		visibleObject.SetActive (true);
	}
}
