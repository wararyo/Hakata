using UnityEngine;
using System.Collections;

public class HakataRoll : MonoBehaviour {

    int x = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        x++;
        transform.rotation = Quaternion.Euler(90, x, 180);
	}
}
