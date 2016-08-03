using UnityEngine;
using System.Collections;

public class NextLevelOnCollide : MonoBehaviour {

    public LevelLoader LL;
    public string Tag;
    public PlayerFollower playerFollower;

    private bool clearFlag = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag(Tag) && !clearFlag)
        {
            clearFlag = true;
            Invoke("DelayMethod", 3);
        }
    }

    void DelayMethod()
    {
        LL.CurrentLevel++;
        clearFlag = false;
    }
}
