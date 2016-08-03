using UnityEngine;
using System.Collections;

public class NextLevelOnCollide : MonoBehaviour {

    public LevelLoader LL;
    public string Tag;
    public PlayerFollower playerFollower;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.CompareTag(Tag))
            Invoke("DelayMethod", 3);
    }

    void DelayMethod()
    {
        LL.CurrentLevel++;
    }
}
