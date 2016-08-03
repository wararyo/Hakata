using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ClearTime : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponent<Text>().text = "Clear time : " + (int)Time.realtimeSinceStartup + "s";
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
